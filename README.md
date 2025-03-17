# To Do List Desktop Application

## __Potential Issues__

### __"Services" needed to connect__

Local SQL Server in use: SQLEXPRESS01

- SQL Server (SQLEXPRESS01)
- SQL Server CEIP service (SQLEXPRESS01)

These need to be manually started (your PC is old)

---

### __Accessing databases on SSMS__

Databases -> ToDoList -> Tables -> dbo.Categories and dbo.TaskList

- dbo.Categories: Contains categories that tasks fall under
- dbo.TaskList: Contains the list of tasks

---

### __Inserting Tasks for testing__

File -> Open -> File -> ToDoList_Query.sql

- ToDoList_Query.sql: Contains code that resets/adds/deletes tables and data for a testing environment

---

### __Rebuiling Executable__

- Build -> Rebuild Solution
- "To Do List App" -> bin -> Debug -> "To Do List App.exe"

Save the new executable as the desktop application
