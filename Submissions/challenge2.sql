CREATE TABLE Department (ID INTEGER NOT NULL PRIMARY KEY, Name varchar(255), Location varchar(255));


CREATE TABLE EMPLOYEE (ID INTEGER PRIMARY KEY NOT NULL, FirstName varchar(255), LastName varchar(255), SSN INTEGER, DeptID INTEGER NOT NULL, FOREIGN KEY (DeptID) REFERENCES Department (ID)  );

CREATE TABLE EmpDetails (ID INTEGER NOT NULL PRIMARY KEY, EmployeeID INTEGER NOT NULL, Salary INTEGER NOT NULL, Address1 varchar(255), Address2 varchar(255), City VARCHAR(255), State TEXT NOT NULL, Country varchar(255), CONSTRAINT fk_Employee_ID FOREIGN KEY (EmployeeID) REFERENCES Employee (ID));

INSERT INTO Department (ID, Name, Location) Values (1, 'Marketing', 'Reston, VA');

INSERT INTO Department (ID, Name, Location) Values (2, 'Consulting', 'Reston, VA');

INSERT INTO Department (ID, Name, Location) Values (3, 'Recruiting', 'Reston, VA');



INSERT INTO Employee (ID, FirstName, LastName, SSN, DeptID) Values (10, 'Jay', 'LastJay', '123456789', 1 );

INSERT INTO Employee (ID, FirstName, LastName, SSN, DeptID) Values (11, 'JayB', 'LastJay', '126456789', 2 );

INSERT INTO Employee (ID, FirstName, LastName, SSN, DeptID) Values (12, 'JayA', 'LastJay', '1234456789', 3 );

INSERT INTO EmpDetails (ID, EmployeeID, Salary, Address1, Address2, City, State, Country) values (21, 10, 12345, '12 annis ave', '13 annis ave', 'Boston', 'Ma', 'USA');

INSERT INTO EmpDetails (ID, EmployeeID, Salary, Address1, Address2, City, State, Country) values (22, 11, 12345, '12 annis ave', '13 annis ave', 'Boston', 'Ma', 'USA');

INSERT INTO EmpDetails (ID, EmployeeID, Salary, Address1, Address2, City, State, Country) values (23, 12, 12345, '12 annis ave', '13 annis ave', 'Boston', 'Ma', 'USA');

INSERT INTO Employee (ID, FirstName, LastName, SSN, DeptID) values (100, 'Tina', 'Smith', 1234556, 1);

INSERT INTO Department (ID, Name, Location ) VALUES (7, 'Marketing', 'Boston, Ma');

select * from EMPLOYEE, Department where Name = 'Marketing';