
/*If 'TaskList' exists, delete the table*/
IF OBJECT_ID('dbo.TaskList', 'U') IS NOT NULL 
DROP TABLE TaskList;

/*Create the 'TaskList' table*/
CREATE TABLE TaskList
(
    ProjectID		INT IDENTITY(1,1)	PRIMARY KEY,
    Title			NVARCHAR(255)		NOT NULL,
    Description		NVARCHAR(MAX)		,
    DueDate			DATETIME			,
	Category		NVARCHAR(255)		,
    Completed		BIT					DEFAULT 0
);

/*Sample Tasks for TaskList database*/
/*
INSERT INTO TaskList (Title, Description, DueDate, Category, Completed)
VALUES 
('Rogers Bill', 'Attempt bill cost reduction', '2024-03-04', 'Household', 0),
('Rogers Bill', 'Attempt sdfg cost reduction', '2024-03-04', 'Household', 0);
*/

SELECT * FROM TaskList;

/*If 'Categories' exist, delete the table*/
IF OBJECT_ID('dbo.Categories', 'U') IS NOT NULL
DROP TABLE dbo.Categories;

/*Create the 'Categories' table*/
CREATE TABLE Categories
(
    CategoryName NVARCHAR(255) NOT NULL,
    PRIMARY KEY (CategoryName)
);

/*Create 'Categories'*/
INSERT INTO Categories (CategoryName)
VALUES
('All'),
('Education'),
('Social'),
('Household')