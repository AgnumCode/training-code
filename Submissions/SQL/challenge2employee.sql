Create database Employee;
go
create schema Emp;
go
create table Emp.Department
(
	Id int primary key identity,
	Name nvarchar(100) not null,
	Location nvarchar(100) not null
);

create table Emp.Employee
(
	Id int primary key identity,
	firstName nvarchar(100) not null,
	lastName nvarchar(100) not null,
	ssn nvarchar(10) not null,
	DeptId int not null
);

create table Emp.EmpDetails
(
	Id int primary key identity,
	employeeId int not null,
	Salary float not null,
	Address1 nvarchar(150) not null,
	Address2 nvarchar(150) not null,
	city nvarchar(100) not null,
	state nvarchar(100) not null,
	country nvarchar(100) not null,
);

ALTER TABLE Emp.Employee
ADD CONSTRAINT FK_deptid_id FOREIGN KEY (DeptId) REFERENCES Emp.Department(Id);

ALTER TABLE Emp.EmpDetails
ADD CONSTRAINT FK_EmpId_id FOREIGN KEY (employeeId) REFERENCES Emp.Employee(Id);

insert into Emp.Department(Name, Location)
values ('IT', 'Reston');
insert into Emp.Department(Name, Location)
values ('HR', 'Washington DC');
insert into Emp.Department(Name, Location)
values ('Sales', 'Herdon');

insert into Emp.Employee(firstName, lastName, ssn, DeptId)
values ('Roy', 'Brow', '486754263', '1');
insert into Emp.Employee(firstName, lastName, ssn, DeptId)
values ('Yessebell', 'Rios', '461637420', '2');
insert into Emp.Employee(firstName, lastName, ssn, DeptId)
values ('Kevin', 'Burgos', '127634779', '3');

insert into Emp.EmpDetails(employeeId, Salary, Address1, Address2, city, state, country)
values ('1', '35000', 'HC 04 Box 13921', 'PO BOX 22135', 'Arecibo', 'Puerto Rico', 'United States');
insert into Emp.EmpDetails(employeeId, Salary, Address1, Address2, city, state, country)
values ('2', '45000', 'HC 07 Box 89427', 'PO BOX 66541', 'Bayamon', 'Puerto Rico', 'United States');
insert into Emp.EmpDetails(employeeId, Salary, Address1, Address2, city, state, country)
values ('1', '50000', 'HC 11 Box 87426', 'PO BOX 11458', 'Ponce', 'Puerto Rico', 'United States');

insert into Emp.Department(Name, Location)
values ('Marketing', 'Herdon');

insert into Emp.Employee(firstName, lastName, ssn, DeptId)
values ('Tina', 'Smith', '987652347', '4');

insert into Emp.EmpDetails(employeeId, Salary, Address1, Address2, city, state, country)
values ('4', '60000', 'HC 90 Box 49876', 'PO BOX 02498', 'New York', 'New York', 'United States');

Select * from Emp.Employee inner join Emp.Department on Emp.Employee.DeptId = Emp.Department.Id where Emp.Department.Name = 'Marketing';

Update Emp.EmpDetails
set Salary = '90000'
where Emp.EmpDetails.employeeId = '4';