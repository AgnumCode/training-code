CREATE TABLE Department
(
    ID INT PRIMARY KEY NOT NULL,
    Name NVARCHAR(50) NOT NULL,
    Location NVARCHAR(100) NOT NULL

)

CREATE TABLE Employee
(
    ID INT PRIMARY KEY NOT NULL,
    FirstName NVARCHAR(25) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    SSN INT NOT NULL,
    DeptID INT FOREIGN KEY REFERENCES Department(ID)
)

CREATE TABLE EmpDetails
(
    ID INT PRIMARY KEY NOT NULL,
    EmployeeID INT FOREIGN KEY REFERENCES Employee(ID),
    Salary DECIMAL(19, 4) NOT NULL,
    Address1 NVARCHAR(50) NOT NULL,
    Address2 NVARCHAR(50),
    City NVARCHAR(50) NOT NULL,
    State NVARCHAR(3) NOT NULL,
    Country NVARCHAR(50)
)

INSERT INTO Department
VALUES ('4', 'Marketing', 'New York'),
 ('1', 'Sales', 'New York'),
('2', 'HR', 'New York'),
('3', 'Finacial', 'New York'),
('4', 'Marketing', 'New York');

INSERT INTO Employee
VALUES ('5', 'Tina', 'Smith', '555776789', '4'),
('4', 'Tina', 'Smith', '555776789', '1'),
('1', 'Keegan', 'OHara', '123456789', '3'),
('2', 'Ludwig', 'Wittgenstein', '923456789', '1'),
('3', 'Martin', 'Heidegger', '555456789', '2');


INSERT INTO EmpDetails
VALUES ('4', '4', '1800000.00', '123 37th St', 'Apt 37C', 'New York', 'NY', 'USA'),
('1', '1', '90000.00', '123 Fake Street', 'Apt 3', 'New York', 'NY', 'USA'),
('2', '2', '1300000.00', '129 Fake Street', 'Apt 9', 'New York', 'NY', 'USA'),
('3', '3', '800000.00', '123 Bleeker Street', 'Apt 37B', 'New York', 'NY', 'USA');

SELECT * FROM Employee
WHERE DeptID IN (SELECT ID FROM Department WHERE Name = 'Marketing');

SELECT SUM(Salary) FROM EmpDetails
WHERE DeptID IN (SELECT ID FROM Department WHERE Name = 'Marketing');


SELECT COUNT(Employee.DeptID) FROM Employee
WHERE DeptID IN (SELECT ID FROM Department WHERE Name = 'Marketing');