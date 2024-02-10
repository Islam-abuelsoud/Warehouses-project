--Create database
create database Warehouses_project;

--create tables

CREATE TABLE Role (
    ID int PRIMARY KEY,
    Name VARCHAR(100),
    Phone VARCHAR(20),
    Email VARCHAR(100),
    Type VARCHAR(50)
);

CREATE TABLE Customer (
    ID int PRIMARY KEY,
    Name VARCHAR(100),
    Phone VARCHAR(20),
    Email VARCHAR(100),
    Address VARCHAR(50)
);
select * from ;
CREATE TABLE Supplier(
    ID int PRIMARY KEY,
    Name VARCHAR(100),
    Phone VARCHAR(20),
    Email VARCHAR(100),
    Address VARCHAR(50)
);

CREATE TABLE Orders (
    ID int PRIMARY KEY,
    Date TIMESTAMP,
    State VARCHAR(50),
	Customer_ID INT,
    FOREIGN KEY (Customer_ID) REFERENCES Customer(ID),
	Supplier_ID INT,
    FOREIGN KEY (Supplier_ID) REFERENCES Supplier(ID)
);

CREATE TABLE Transactions(
	ID int PRIMARY KEY,
    Date TIMESTAMP ,
    Type VARCHAR(50),
	Amount int,
	Order_ID int,
	FOREIGN KEY (Order_ID) REFERENCES Orders(ID),
	Role_ID int,
	FOREIGN KEY (Role_ID) REFERENCES Role(ID)
);

CREATE TABLE Delivery(
	ID int PRIMARY KEY,
    Name VARCHAR(100),
    Phone VARCHAR(20),
	Date TIMESTAMP,
    State VARCHAR(50),
	Order_ID int,
	FOREIGN KEY (Order_ID) REFERENCES Orders(ID)
);

CREATE TABLE Order_Item(
	ID int PRIMARY KEY,
	Quantity int,
	Cost int,
	Description VARCHAR(100),
	Order_ID int,
	FOREIGN KEY (Order_ID) REFERENCES Orders(ID),
	Product_ID int,
	FOREIGN KEY (Product_ID) REFERENCES Product(ID)

);

CREATE TABLE Product (
	ID int PRIMARY KEY,
    Name VARCHAR(100),
	Description VARCHAR(100),
	Type VARCHAR(50),
	Quantity int,
	Price int,
	Image VARBINARY(MAX),
	Inventory_ID int,
	FOREIGN KEY (Inventory_ID) REFERENCES Inventory(ID)
);

CREATE TABLE Inventory(
	ID int PRIMARY KEY,
	Type VARCHAR(50),
	Quantity int,
	Order_ID int,
	FOREIGN KEY (Order_ID) REFERENCES Orders(ID)
);




--insert data

INSERT INTO Role (ID, Name, Phone, Email, Type) VALUES
(1, 'Manager 1', '111-111-1111', 'manager1@example.com', 'manager'),
(2, 'Manager 2', '222-222-2222', 'manager2@example.com', 'manager'),
(3, 'Staff 1', '333-333-3333', 'staff1@example.com', 'staff'),
(4, 'Staff 2', '444-444-4444', 'staff2@example.com', 'staff'),
(5, 'Staff 3', '555-555-5555', 'staff3@example.com', 'staff');

-------------------------------
INSERT INTO Customer (ID, Name, Phone, Email, Address) VALUES
(1, 'John Doe', '123-456-7890', 'john.doe@example.com', '123 Main St'),
(2, 'Jane Smith', '987-654-3210', 'jane.smith@example.com', '456 Elm St'),
(3, 'Michael Johnson', '555-123-4567', 'michael.johnson@example.com', '789 Oak Ave'),
(4, 'Emily Davis', '111-222-3333', 'emily.davis@example.com', '101 Pine St'),
(5, 'David Wilson', '999-888-7777', 'david.wilson@example.com', '202 Maple Dr'),
(6, 'Sarah Brown', '444-555-6666', 'sarah.brown@example.com', '303 Cedar Ln'),
(7, 'James Taylor', '777-888-9999', 'james.taylor@example.com', '404 Birch Rd'),
(8, 'Jessica Lee', '666-555-4444', 'jessica.lee@example.com', '505 Walnut Ave'),
(9, 'Andrew Miller', '222-333-4444', 'andrew.miller@example.com', '606 Oak St'),
(10, 'Olivia Martinez', '888-777-6666', 'olivia.martinez@example.com', '707 Pine Ln');

-------------------------
INSERT INTO Supplier (ID, Name, Phone, Email, Address) VALUES
(1, 'Supplier 1', '111-111-1111', 'supplier1@example.com', '123 Supplier St'),
(2, 'Supplier 2', '222-222-2222', 'supplier2@example.com', '456 Supplier Ave'),
(3, 'Supplier 3', '333-333-3333', 'supplier3@example.com', '789 Supplier Rd'),
(4, 'Supplier 4', '444-444-4444', 'supplier4@example.com', '101 Supplier Blvd'),
(5, 'Supplier 5', '555-555-5555', 'supplier5@example.com', '202 Supplier Ln'),
(6, 'Supplier 6', '666-666-6666', 'supplier6@example.com', '303 Supplier Dr'),
(7, 'Supplier 7', '777-777-7777', 'supplier7@example.com', '404 Supplier Way'),
(8, 'Supplier 8', '888-888-8888', 'supplier8@example.com', '505 Supplier Ct'),
(9, 'Supplier 9', '999-999-9999', 'supplier9@example.com', '606 Supplier Pl'),
(10, 'Supplier 10', '000-000-0000', 'supplier10@example.com', '707 Supplier Cir');
----------------------------------
INSERT INTO Orders (ID,State, Customer_ID, Supplier_ID) VALUES
(1, 'Pending', 1, 1),
(2, 'Confirmed', 2, 2),
(3, 'Shipped', 3, 3),
(4, 'Delivered', 4, 4),
(5, 'Pending', 5, 5);
----------------------------------
INSERT INTO Product (ID, Name, Description, Type, Quantity, Price, Image, Inventory_ID) VALUES
(1, 'Product 1', 'Description of Product 1', 'Type 1', 10, 100, NULL, 1),
(2, 'Product 2', 'Description of Product 2', 'Type 2', 20, 200, NULL, 2),
(3, 'Product 3', 'Description of Product 3', 'Type 3', 30, 300, NULL, 3),
(4, 'Product 4', 'Description of Product 4', 'Type 1', 40, 400, NULL, 1),
(5, 'Product 5', 'Description of Product 5', 'Type 2', 50, 500, NULL, 2);
----------------------------------
INSERT INTO Inventory (ID, Type, Quantity, Order_ID) VALUES
(1, 'Type 1', 10, 1),
(2, 'Type 2', 20, 2),
(3, 'Type 3', 30, 3),
(4, 'Type 1', 40, 4),
(5, 'Type 2', 50, 5);

--------------------
INSERT INTO Delivery (ID, Name, Phone,  State, Order_ID) VALUES
(1, 'John Doe', '123-456-7890',  'Pending', 1),
(2, 'Jane Smith', '987-654-3210',  'Confirmed', 2),
(3, 'Michael Johnson', '555-123-4567','Shipped', 3),
(4, 'Emily Davis', '111-222-3333', 'Delivered', 4),
(5, 'David Wilson', '999-888-7777', 'Pending', 5);
-----------------------------------------
INSERT INTO Order_Item (ID, Quantity, Cost, Description, Order_ID, Product_ID) VALUES
(1, 2, 20, 'Description for item 1', 1, 1),
(2, 3, 30, 'Description for item 2', 1, 2),
(3, 1, 10, 'Description for item 3', 2, 3),
(4, 4, 40, 'Description for item 4', 3, 4),
(5, 2, 20, 'Description for item 5', 3, 5);
----------------------------------------
INSERT INTO Transactions (ID, Type, Amount, Order_ID, Role_ID) VALUES
(1, 'Sale', 100, 1, 1),
(2,  'Sale', 200, 2, 2),
(3,  'Sale', 300, 3, 3),
(4,'Sale', 400, 4, 4),
(5,  'Sale', 500, 5, 5);


