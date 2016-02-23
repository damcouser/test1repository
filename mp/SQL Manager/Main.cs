using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Manager
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			splitContainer2.Panel2Collapsed = true;
		}

		private void Main_Load(object sender, EventArgs e)
		{
			cbConnectionString.Text = FindDatabase(Environment.CurrentDirectory) ?? @"Data Source=(LocalDB)\v11.0;Integrated Security=True;Connect Timeout=30";

			RefreshMetaData();
		}

		private void RefreshMetaData()
		{
			tvMetaData.BeginUpdate();
			foreach (var node in tvMetaData.Nodes.Cast<TreeNode>())
			{
				node.Nodes.Clear();
			}

			try
			{
				var database = GetDatabase();
				foreach (var table in database.Tables.Cast<Table>())
				{
					var node = tvMetaData.Nodes["Tables"].Nodes.Add(table.Name);
					tvMetaData.Nodes["Tables"].Expand();

					foreach (var column in table.Columns.Cast<Column>())
						node.Nodes.Add(String.Format("{0} ({1}{2})", column.Name, column.DataType, column.Nullable ? " [nullable]" : String.Empty));
				}

				foreach (var view in database.Views.Cast<Microsoft.SqlServer.Management.Smo.View>())
				{
					if (view.IsSystemObject) continue;
					var node = tvMetaData.Nodes["Views"].Nodes.Add(view.Name);
					tvMetaData.Nodes["Views"].Expand();

					foreach (var column in view.Columns.Cast<Column>())
						node.Nodes.Add(String.Format("{0} ({1}{2})", column.Name, column.DataType, column.Nullable ? " [nullable]" : String.Empty));
				}

				foreach (var procedure in database.StoredProcedures.Cast<StoredProcedure>())
				{
					if (procedure.IsSystemObject) continue;
					var node = tvMetaData.Nodes["StoredProcedures"].Nodes.Add(procedure.Name);
					tvMetaData.Nodes["StoredProcedures"].Expand();

					foreach (var param in procedure.Parameters.Cast<StoredProcedureParameter>())
						node.Nodes.Add(String.Format("{0} ({1})", param.Name, param.DataType));
				}
			}
			catch { }

			tvMetaData.EndUpdate();
		}

		private Database GetDatabase()
		{
			//@"Data Source=(LocalDB)\v11.0;AttachDbFilename=Z:\Code\Motesplatsen\Web\App_Data\Database.mdf;Integrated Security=True;Connect Timeout=30"
			var connection = new ServerConnection(new SqlConnection(cbConnectionString.Text));
			var server = new Server(connection);
			return server.Databases.Cast<Database>().SingleOrDefault(d => d.Name.Contains(@"WEB\APP_DATA\DATABASE.MDF"));
		}

		private String FindDatabase(String path)
		{
			var dir = new DirectoryInfo(path);
			if (Directory.Exists(Path.Combine(dir.FullName, "Web")))
			{
				if (File.Exists(Path.Combine(dir.FullName, @"Web\App_Data\Database.mdf")))
					return String.Format(@"Data Source=(LocalDB)\v11.0;AttachDbFilename={0};Integrated Security=True;Connect Timeout=30", Path.Combine(dir.FullName, @"Web\App_Data\Database.mdf"));
				else
					return null;
			}
			else if (dir.Parent != null)
				return FindDatabase(dir.Parent.FullName);
			else
				return null;
		}

		private void fctbSQL_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.F5)
			{
				txtOutput.Text = String.Empty;

				if (splitContainer2.Panel2Collapsed)
					splitContainer2.Panel2Collapsed = false;

				try
				{
					var timer = Stopwatch.StartNew();

					using (var connection = Logic.Data.Connection.Database.Connect(cbConnectionString.Text))
					using (var command = Logic.Data.Connection.Database.Command(fctbSQL.Text, connection))
					using (var adapter = new SqlDataAdapter(command))
					{
						var output = new DataSet();
						var affected = adapter.Fill(output);
						txtOutput.Text = String.Format("Affected Row(s): {0}", affected);
						if (output.Tables.Count > 0)
						{
							dgvOutput.DataSource = output.Tables[0];
							if (!tabControl1.TabPages.Contains(tpResult))
								tabControl1.TabPages.Insert(0, tpResult);
							tabControl1.SelectTab(tpResult);
						}
						else
						{
							if (tabControl1.TabPages.Contains(tpResult))
								tabControl1.TabPages.Remove(tpResult);
							tabControl1.SelectTab(tpMessage);
						}
					}

					timer.Stop();
					txtOutput.Text += Environment.NewLine + Environment.NewLine;
					txtOutput.Text += String.Format("Query completed in: {0}.", timer.Elapsed);
				}
				catch (Exception ex)
				{
					txtOutput.Text = ex.Message
						+ Environment.NewLine
						+ Environment.NewLine
						+ ex.StackTrace;

					tabControl1.SelectTab(tpMessage);
				}
				
				fctbSQL.Focus();
			}
		}

		private void cbConnectionString_TextChanged(object sender, EventArgs e)
		{
			RefreshMetaData();
		}

		private void tvMetaData_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			// Script something?
		}

		private void tvMetaData_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Right)
			{
				if (e.Node.Parent == null) return;
				if (e.Node.Parent.Parent != null) return;
				tsmiSELECT.Visible = e.Node.Parent.Text.Equals("Tables");

				var name = e.Node.Text;
				var type = e.Node.Parent.Text;
				var database = GetDatabase();

				switch (type)
				{
					case "Tables":
						script = Script(database.Parent, database.Tables[name]);
						select = name;
						break;
					case "Views":
						script = Script(database.Parent, database.Views[name]);
						break;
					case "Stored Procedures":
						script = Script(database.Parent, database.StoredProcedures[name]);
						break;
				}
				
				cmsScript.Show(tvMetaData, e.Location);
			}
		}

		private String Script(Server server, SqlSmoObject obj)
		{
			var scripter = new Scripter(server);
			scripter.Options.ScriptDrops = true;
			scripter.Options.IncludeIfNotExists = true;
			var drop = scripter.Script(new[] { obj.Urn });
			scripter.Options.ScriptDrops = false;
			scripter.Options.IncludeIfNotExists = false;
			var create = scripter.Script(new[] { obj.Urn });

			var builder = new StringBuilder();

			foreach (var line in drop)
				builder.AppendLine(line);

			builder.AppendLine(String.Empty);

			foreach (var line in create)
				builder.AppendLine(line);

			return builder.ToString();
		}

		private String script = String.Empty;
		private String select = String.Empty;
		private void tsmiScript_Click(object sender, EventArgs e)
		{
			fctbSQL.Text = script;
		}

		private void tsmiSELECT_Click(object sender, EventArgs e)
		{
			fctbSQL.Text = String.Format("SELECT *\r\n  FROM [dbo].[{0}];", select);
		}
	}
}
