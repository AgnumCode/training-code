GO 
-- create Customer Table

Create Table Movies.Department 
(
	DepartmentID INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(128) NOT NULL,
	Location NVARCHAR(128) NOT NULL
);

GO
CREATE TABLE Movies.Employee
(
	EmployeeID INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(128) NOT NULL,f
	LastName NVARCHAR(128) NOT NULL,
	SSN NVARCHAR(11) NOT NULL,
	DepartmentID int FOREIGN KEY REFERENCES Movies.Department(DepartmentID)
);

GO
CREATE TABLE Movies.EmpDetails
(
	EmpDetailsID INT PRIMARY KEY IDENTITY,
	EmployeeID int FOREIGN KEY REFERENCES Movies.Employee(EmployeeID),
	Salary INT NOT NULL,
	Address1 NVARCHAR(128) NOT NULL,
	Address2 NVARCHAR(128) NOT NULL,
	City NVARCHAR(128) NOT NULL,
	St	NVARCHAR(128) NOT NULL,
	Country NVARCHAR(128) NOT NULL
);

