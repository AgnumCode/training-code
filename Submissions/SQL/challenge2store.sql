CREATE TABLE Products
(
    ID INT PRIMARY KEY NOT NULL,
    Name NVARCHAR(50) NOT NULL,
    Price Decimal(10, 4) NOT NULL
)


CREATE TABLE Customers
(
    ID INT PRIMARY KEY NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    CardNumber INT NOT NULL
)


CREATE TABLE Orders
(
    ID INT NOT NULL,
    ProductID INT FOREIGN KEY REFERENCES Products(ID),
    CustomerID INT FOREIGN KEY REFERENCES Customers(ID)
)

-- Inserted Tina Smith and 2 others to make 3
INSERT INTO Customers
VALUES ('1', 'Tina', 'Smith', '123465'),
('2', 'Joe', 'Smith', '777465'),
('3', 'Ron', 'Joseph', '333675');

-- Inserted iPhone and 2 others to make 3
INSERT INTO Products
VALUES ('1', 'iPhone', '300.00'),
('2', 'iPhone X', '1300.00'),
('3', 'Samsung Galaxy', '999.00');

-- Inserted Tina's order for an iPhone and 2 others to make 3
INSERT INTO Orders
VALUES ('1', '1', '1'),
('2', '3', '2'),
('3', '2', '3');


-- All orders by Tina Smith
SELECT * FROM Orders
WHERE CustomerID IN (SELECT ID FROM Customers WHERE FirstName = 'Tina' AND LastName = 'Smith');

-- ALL revenue for iPhone sales
SELECT (Products.Price * COUNT(ProductID)) FROM Products
JOIN Orders ON (Orders.ProductID = Products.ID)
GROUP BY Products.Price;


