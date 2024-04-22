CREATE TABLE Category(
	id INT PRIMARY KEY IDENTITY(1,1),
	[name] VARCHAR(20) UNIQUE NOT NULL,
)

CREATE TABLE Customers(
	id INT PRIMARY KEY IDENTITY(1,1),
	[name] VARCHAR(20) NOT NULL,
	email VARCHAR(20),
	phone VARCHAR(20) ,
	[address] VARCHAR(100)
)

CREATE TABLE Products(
	id INT PRIMARY KEY IDENTITY(1,1),
	[name] VARCHAR(20) UNIQUE NOT NULL,
	category INT NOT NULL,
	price decimal(10, 2),
	shelveDate DATETIME	NOT NULL DEFAULT getDate()
	FOREIGN KEY (category) REFERENCES Category(id)
)

CREATE TABLE Orders(
	id INT PRIMARY KEY NOT NULL,
	customerID INT NOT NULL,
	orderDate DATETIME	NOT NULL DEFAULT getDate(),
	FOREIGN KEY (customerID) REFERENCES Customers(id)
)

CREATE TABLE OrderDetails (
    orderID INT,
    productID INT,
    quantity INT,
    FOREIGN KEY (orderID) REFERENCES Orders(id),
    FOREIGN KEY (productID) REFERENCES Products(id)
);