CREATE TABLE Admin (
    AdminUserName NVARCHAR(50) PRIMARY KEY,
	AdminPassword NVARCHAR(50),
);
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(255)
);
CREATE TABLE Customers (
    CustomerUsername NVARCHAR(50) PRIMARY KEY,
	CustomerPassword NVARCHAR(50),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100),
    Phone NVARCHAR(15)
);
CREATE TABLE Employee (
    EmployeeUsername NVARCHAR(50) PRIMARY KEY,
	EmployeePassword NVARCHAR(50),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100),
    Phone NVARCHAR(15),
	Salary INT
);	
CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(255),
    CategoryID INT,
    Price DECIMAL(10, 2),
    StockQuantity INT,
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
	OrderDate DATETIME,
    CustomerUsername NVARCHAR(50),
	ProductID INT,
	Quantity INT,
	TotalPrice DECIMAL(10, 2),
	OrderStatus NVARCHAR(1)
		CONSTRAINT CHK_OrderStatus CHECK (OrderStatus IN ('A','G')),
	FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CustomerUsername) REFERENCES Customers(CustomerUsername)
);
CREATE TABLE OrderHistory (
    OrderHistoryID INT PRIMARY KEY IDENTITY(1,1),
	OrderDate DATETIME,
	CustomerUsername NVARCHAR(50),
    ProductID INT,
    Quantity INT,
	TotalPrice DECIMAL(10, 2),
	OrderHistoryDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
	FOREIGN KEY (CustomerUsername) REFERENCES Customers(CustomerUsername),
);
CREATE TABLE DeletedRecords (
    Table_Name NVARCHAR(255),
    Record_ID NVARCHAR(55),
    DeletedAt DATETIME
);



UPDATE Orders
SET TotalPrice = Quantity * (SELECT Price FROM Products WHERE ProductID = Orders.ProductID);
SET OrderDate = GETDATE();