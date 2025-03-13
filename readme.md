# Issue with starting server on SSMS

## "Services" needed to connect

Local SQL Server in use: SQLEXPRESS01

- SQL Server (SQLEXPRESS01)
- SQL Server CEIP service (SQLEXPRESS01)

These need to be manually started (your PC is old)

## Accessing databases on SSMS

Databases -> ToDoList -> Tables -> dbo.Categories and dbo.TaskList

- dbo.Categories: Contains categories that tasks fall under
- dbo.TaskList: Contains the list of tasks

## Inserting Tasks for testing

File -> Open -> File -> ToDoList_Query.sql

- ToDoList_Query.sql: Contains code that resets/adds/deletes tables and data for a testing environment.