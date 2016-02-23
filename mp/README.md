# MP

----------

### **SQL Server**
1. In **Visual Studio**
	- [ ] `View` > `Server Explorer`
	- [ ] `Connect to database`
	- [ ] Data source: `Microsoft SQL Server Database File (SqlClient)`
	- [ ] Database file name (new or existing): `<proj>\Web\App_Data\Database.mdf`
		- If there is an error make sure you have the latest version of [SQL Server Data Tools](https://msdn.microsoft.com/en-us/library/mt204009.aspx?f=255&MSPPError=-2147217396)
		- There is also a very simple manager for LocalDB included in the project
2. Alter `[dbo].[GetMessages]`
	- [ ] Include `[Username]` from `[dbo].[User]` so ember can display a name instead of an id.
3. Create `[dbo].[GetMessage]`
	- [ ] Should return a single message from the above list (used when the user clicks on a message).

----------
 
### **C#**
1. Open **Logic\Message.cs**
	- [ ] Add the new property from database.
2. Open **Web\Models\MessageModel.cs**
	- [ ] Add the new property from database.
3. Open **Web\Controllers\MessagesController.cs**
	- [ ] Fix: `private IEnumerable<Logic.Message> SortByThread(List<Logic.Message> list)`.
4. Open **Web\Controllers\MessageController.cs**
	- [ ] Fix: `public IHttpActionResult Get([FromUri]Int32 id)` so that it uses the new Stored Procedure from above.

----------

### **Ember (javascript)**
1. Open **Web\Scripts\spa\controllers\messages_controller.js**
	- [ ] Create implementation for the `byThread` action 
2. Open **Web\Scripts\spa\models\message_model.js**
	- [ ] Add the new property from database
3. Open **Web\Views\Home\Index.cshtml**
	- [ ] Display: `Author` (Username from above), `Date`, `Status` in messages-view
	- [ ] Display: `Author` (Username from above), `Date`, `Text` in message-view

----------

### Miscellaneous
- [ ] Add CSS and make the pages slightly more appealing.
	- Coloring of every other line in messages view
	- Prettify buttons and input fields
	- Spend a few minutes doing what you can think of
- [ ] Bundle javascripts (Web\App_Start\BundleConfig.cs).
- [ ] Format dates (any human readable format).
- [ ] Automatic transition to messages when already logged in.
- [ ] Fix potential bugs and issues in the code.

----------