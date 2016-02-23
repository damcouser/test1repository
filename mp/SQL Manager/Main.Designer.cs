namespace SQL_Manager
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Tables");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Views");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Stored Procedures");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Functions");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Synonyms");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Types");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Assemblies");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.cbConnectionString = new System.Windows.Forms.ComboBox();
			this.tvMetaData = new System.Windows.Forms.TreeView();
			this.fctbSQL = new FastColoredTextBoxNS.FastColoredTextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tpResult = new System.Windows.Forms.TabPage();
			this.dgvOutput = new System.Windows.Forms.DataGridView();
			this.tpMessage = new System.Windows.Forms.TabPage();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.cmsScript = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiScript = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSELECT = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.fctbSQL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tpResult.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
			this.tpMessage.SuspendLayout();
			this.cmsScript.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbConnectionString
			// 
			this.cbConnectionString.Dock = System.Windows.Forms.DockStyle.Top;
			this.cbConnectionString.FormattingEnabled = true;
			this.cbConnectionString.Location = new System.Drawing.Point(0, 0);
			this.cbConnectionString.Name = "cbConnectionString";
			this.cbConnectionString.Size = new System.Drawing.Size(188, 21);
			this.cbConnectionString.TabIndex = 0;
			this.cbConnectionString.TextChanged += new System.EventHandler(this.cbConnectionString_TextChanged);
			// 
			// tvMetaData
			// 
			this.tvMetaData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvMetaData.Location = new System.Drawing.Point(0, 21);
			this.tvMetaData.Name = "tvMetaData";
			treeNode1.Name = "Tables";
			treeNode1.Text = "Tables";
			treeNode2.Name = "Views";
			treeNode2.Text = "Views";
			treeNode3.Name = "StoredProcedures";
			treeNode3.Text = "Stored Procedures";
			treeNode4.Name = "Functions";
			treeNode4.Text = "Functions";
			treeNode5.Name = "Synonyms";
			treeNode5.Text = "Synonyms";
			treeNode6.Name = "Types";
			treeNode6.Text = "Types";
			treeNode7.Name = "Assemblies";
			treeNode7.Text = "Assemblies";
			this.tvMetaData.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
			this.tvMetaData.ShowRootLines = false;
			this.tvMetaData.Size = new System.Drawing.Size(188, 453);
			this.tvMetaData.TabIndex = 1;
			this.tvMetaData.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMetaData_NodeMouseClick);
			this.tvMetaData.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMetaData_NodeMouseDoubleClick);
			// 
			// fctbSQL
			// 
			this.fctbSQL.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
			this.fctbSQL.AutoIndentCharsPatterns = "";
			this.fctbSQL.AutoScrollMinSize = new System.Drawing.Size(27, 14);
			this.fctbSQL.BackBrush = null;
			this.fctbSQL.CharHeight = 14;
			this.fctbSQL.CharWidth = 8;
			this.fctbSQL.CommentPrefix = "--";
			this.fctbSQL.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.fctbSQL.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.fctbSQL.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fctbSQL.Font = new System.Drawing.Font("Courier New", 9.75F);
			this.fctbSQL.IsReplaceMode = false;
			this.fctbSQL.Language = FastColoredTextBoxNS.Language.SQL;
			this.fctbSQL.LeftBracket = '(';
			this.fctbSQL.Location = new System.Drawing.Point(0, 0);
			this.fctbSQL.Name = "fctbSQL";
			this.fctbSQL.Paddings = new System.Windows.Forms.Padding(0);
			this.fctbSQL.RightBracket = ')';
			this.fctbSQL.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.fctbSQL.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbSQL.ServiceColors")));
			this.fctbSQL.Size = new System.Drawing.Size(855, 237);
			this.fctbSQL.TabIndex = 2;
			this.fctbSQL.Zoom = 100;
			this.fctbSQL.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.fctbSQL_PreviewKeyDown);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tvMetaData);
			this.splitContainer1.Panel1.Controls.Add(this.cbConnectionString);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(1047, 474);
			this.splitContainer1.SplitterDistance = 188;
			this.splitContainer1.TabIndex = 3;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.fctbSQL);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer2.Size = new System.Drawing.Size(855, 474);
			this.splitContainer2.SplitterDistance = 237;
			this.splitContainer2.TabIndex = 3;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tpResult);
			this.tabControl1.Controls.Add(this.tpMessage);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(855, 233);
			this.tabControl1.TabIndex = 1;
			// 
			// tpResult
			// 
			this.tpResult.Controls.Add(this.dgvOutput);
			this.tpResult.Location = new System.Drawing.Point(4, 22);
			this.tpResult.Name = "tpResult";
			this.tpResult.Padding = new System.Windows.Forms.Padding(3);
			this.tpResult.Size = new System.Drawing.Size(847, 207);
			this.tpResult.TabIndex = 0;
			this.tpResult.Text = "Result";
			this.tpResult.UseVisualStyleBackColor = true;
			// 
			// dgvOutput
			// 
			this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvOutput.Location = new System.Drawing.Point(3, 3);
			this.dgvOutput.Name = "dgvOutput";
			this.dgvOutput.Size = new System.Drawing.Size(841, 201);
			this.dgvOutput.TabIndex = 0;
			// 
			// tpMessage
			// 
			this.tpMessage.Controls.Add(this.txtOutput);
			this.tpMessage.Location = new System.Drawing.Point(4, 22);
			this.tpMessage.Name = "tpMessage";
			this.tpMessage.Padding = new System.Windows.Forms.Padding(3);
			this.tpMessage.Size = new System.Drawing.Size(847, 207);
			this.tpMessage.TabIndex = 1;
			this.tpMessage.Text = "Message";
			this.tpMessage.UseVisualStyleBackColor = true;
			// 
			// txtOutput
			// 
			this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtOutput.Location = new System.Drawing.Point(3, 3);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtOutput.Size = new System.Drawing.Size(841, 201);
			this.txtOutput.TabIndex = 0;
			this.txtOutput.WordWrap = false;
			// 
			// cmsScript
			// 
			this.cmsScript.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiScript,
            this.tsmiSELECT});
			this.cmsScript.Name = "cmsScript";
			this.cmsScript.Size = new System.Drawing.Size(114, 48);
			// 
			// tsmiScript
			// 
			this.tsmiScript.Name = "tsmiScript";
			this.tsmiScript.Size = new System.Drawing.Size(113, 22);
			this.tsmiScript.Text = "Script";
			this.tsmiScript.Click += new System.EventHandler(this.tsmiScript_Click);
			// 
			// tsmiSELECT
			// 
			this.tsmiSELECT.Name = "tsmiSELECT";
			this.tsmiSELECT.Size = new System.Drawing.Size(113, 22);
			this.tsmiSELECT.Text = "SELECT";
			this.tsmiSELECT.Click += new System.EventHandler(this.tsmiSELECT_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1047, 474);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Main";
			this.Text = "Management Studio (press [F5] to run query)";
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.fctbSQL)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tpResult.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
			this.tpMessage.ResumeLayout(false);
			this.tpMessage.PerformLayout();
			this.cmsScript.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cbConnectionString;
		private System.Windows.Forms.TreeView tvMetaData;
		private FastColoredTextBoxNS.FastColoredTextBox fctbSQL;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ContextMenuStrip cmsScript;
		private System.Windows.Forms.ToolStripMenuItem tsmiScript;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.DataGridView dgvOutput;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpResult;
		private System.Windows.Forms.TabPage tpMessage;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.ToolStripMenuItem tsmiSELECT;
	}
}

