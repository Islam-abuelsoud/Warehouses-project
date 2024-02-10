USE [master]
GO
/****** Object:  Database [Warehouses_project]    Script Date: 2/10/2024 2:19:51 AM ******/
CREATE DATABASE [Warehouses_project]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Warehouses_project', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Warehouses_project.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Warehouses_project_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Warehouses_project_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Warehouses_project] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Warehouses_project].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Warehouses_project] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Warehouses_project] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Warehouses_project] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Warehouses_project] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Warehouses_project] SET ARITHABORT OFF 
GO
ALTER DATABASE [Warehouses_project] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Warehouses_project] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Warehouses_project] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Warehouses_project] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Warehouses_project] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Warehouses_project] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Warehouses_project] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Warehouses_project] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Warehouses_project] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Warehouses_project] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Warehouses_project] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Warehouses_project] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Warehouses_project] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Warehouses_project] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Warehouses_project] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Warehouses_project] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Warehouses_project] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Warehouses_project] SET RECOVERY FULL 
GO
ALTER DATABASE [Warehouses_project] SET  MULTI_USER 
GO
ALTER DATABASE [Warehouses_project] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Warehouses_project] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Warehouses_project] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Warehouses_project] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Warehouses_project] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Warehouses_project] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Warehouses_project', N'ON'
GO
ALTER DATABASE [Warehouses_project] SET QUERY_STORE = ON
GO
ALTER DATABASE [Warehouses_project] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Warehouses_project]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2/10/2024 2:19:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [int] NOT NULL,
	[Name] [varchar](100) NULL,
	[Phone] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
	[Address] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Delivery]    Script Date: 2/10/2024 2:19:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Delivery](
	[ID] [int] NOT NULL,
	[Name] [varchar](100) NULL,
	[Phone] [varchar](20) NULL,
	[Date] [timestamp] NOT NULL,
	[State] [varchar](50) NULL,
	[Order_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 2/10/2024 2:19:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[ID] [int] NOT NULL,
	[Type] [varchar](50) NULL,
	[Quantity] [int] NULL,
	[Order_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_Item]    Script Date: 2/10/2024 2:19:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Item](
	[ID] [int] NOT NULL,
	[Quantity] [int] NULL,
	[Cost] [int] NULL,
	[Description] [varchar](100) NULL,
	[Order_ID] [int] NULL,
	[Product_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2/10/2024 2:19:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [int] NOT NULL,
	[Date] [timestamp] NOT NULL,
	[State] [varchar](50) NULL,
	[Customer_ID] [int] NULL,
	[Supplier_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2/10/2024 2:19:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] NOT NULL,
	[Name] [varchar](100) NULL,
	[Description] [varchar](100) NULL,
	[Type] [varchar](50) NULL,
	[Quantity] [int] NULL,
	[Price] [int] NULL,
	[Image] [varbinary](max) NULL,
	[Inventory_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 2/10/2024 2:19:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] NOT NULL,
	[Name] [varchar](100) NULL,
	[Phone] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
	[Type] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 2/10/2024 2:19:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[ID] [int] NOT NULL,
	[Name] [varchar](100) NULL,
	[Phone] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
	[Address] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 2/10/2024 2:19:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[ID] [int] NOT NULL,
	[Date] [timestamp] NOT NULL,
	[Type] [varchar](50) NULL,
	[Amount] [int] NULL,
	[Order_ID] [int] NULL,
	[Role_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Customer] ([ID], [Name], [Phone], [Email], [Address]) VALUES (1, N'John Doe', N'123-456-7890', N'john.doe@example.com', N'123 Main St')
INSERT [dbo].[Customer] ([ID], [Name], [Phone], [Email], [Address]) VALUES (2, N'Jane Smith', N'987-654-3210', N'jane.smith@example.com', N'456 Elm St')
INSERT [dbo].[Customer] ([ID], [Name], [Phone], [Email], [Address]) VALUES (3, N'Michael Johnson', N'555-123-4567', N'michael.johnson@example.com', N'789 Oak Ave')
INSERT [dbo].[Customer] ([ID], [Name], [Phone], [Email], [Address]) VALUES (4, N'Emily Davis', N'111-222-3333', N'emily.davis@example.com', N'101 Pine St')
INSERT [dbo].[Customer] ([ID], [Name], [Phone], [Email], [Address]) VALUES (5, N'David Wilson', N'999-888-7777', N'david.wilson@example.com', N'202 Maple Dr')
INSERT [dbo].[Customer] ([ID], [Name], [Phone], [Email], [Address]) VALUES (6, N'Sarah Brown', N'444-555-6666', N'sarah.brown@example.com', N'303 Cedar Ln')
INSERT [dbo].[Customer] ([ID], [Name], [Phone], [Email], [Address]) VALUES (7, N'James Taylor', N'777-888-9999', N'james.taylor@example.com', N'404 Birch Rd')
INSERT [dbo].[Customer] ([ID], [Name], [Phone], [Email], [Address]) VALUES (8, N'Jessica Lee', N'666-555-4444', N'jessica.lee@example.com', N'505 Walnut Ave')
INSERT [dbo].[Customer] ([ID], [Name], [Phone], [Email], [Address]) VALUES (9, N'Andrew Miller', N'222-333-4444', N'andrew.miller@example.com', N'606 Oak St')
INSERT [dbo].[Customer] ([ID], [Name], [Phone], [Email], [Address]) VALUES (10, N'Olivia Martinez', N'888-777-6666', N'olivia.martinez@example.com', N'707 Pine Ln')
GO
INSERT [dbo].[Delivery] ([ID], [Name], [Phone], [State], [Order_ID]) VALUES (1, N'John Doe', N'123-456-7890', N'Pending', 1)
INSERT [dbo].[Delivery] ([ID], [Name], [Phone], [State], [Order_ID]) VALUES (2, N'Jane Smith', N'987-654-3210', N'Confirmed', 2)
INSERT [dbo].[Delivery] ([ID], [Name], [Phone], [State], [Order_ID]) VALUES (3, N'Michael Johnson', N'555-123-4567', N'Shipped', 3)
INSERT [dbo].[Delivery] ([ID], [Name], [Phone], [State], [Order_ID]) VALUES (4, N'Emily Davis', N'111-222-3333', N'Delivered', 4)
INSERT [dbo].[Delivery] ([ID], [Name], [Phone], [State], [Order_ID]) VALUES (5, N'David Wilson', N'999-888-7777', N'Pending', 5)
GO
INSERT [dbo].[Inventory] ([ID], [Type], [Quantity], [Order_ID]) VALUES (1, N'Type 1', 10, 1)
INSERT [dbo].[Inventory] ([ID], [Type], [Quantity], [Order_ID]) VALUES (2, N'Type 2', 20, 2)
INSERT [dbo].[Inventory] ([ID], [Type], [Quantity], [Order_ID]) VALUES (3, N'Type 3', 30, 3)
INSERT [dbo].[Inventory] ([ID], [Type], [Quantity], [Order_ID]) VALUES (4, N'Type 1', 40, 4)
INSERT [dbo].[Inventory] ([ID], [Type], [Quantity], [Order_ID]) VALUES (5, N'Type 2', 50, 5)
GO
INSERT [dbo].[Order_Item] ([ID], [Quantity], [Cost], [Description], [Order_ID], [Product_ID]) VALUES (1, 2, 20, N'Description for item 1', 1, 1)
INSERT [dbo].[Order_Item] ([ID], [Quantity], [Cost], [Description], [Order_ID], [Product_ID]) VALUES (2, 3, 30, N'Description for item 2', 1, 2)
INSERT [dbo].[Order_Item] ([ID], [Quantity], [Cost], [Description], [Order_ID], [Product_ID]) VALUES (3, 1, 10, N'Description for item 3', 2, 3)
INSERT [dbo].[Order_Item] ([ID], [Quantity], [Cost], [Description], [Order_ID], [Product_ID]) VALUES (4, 4, 40, N'Description for item 4', 3, 4)
INSERT [dbo].[Order_Item] ([ID], [Quantity], [Cost], [Description], [Order_ID], [Product_ID]) VALUES (5, 2, 20, N'Description for item 5', 3, 5)
GO
INSERT [dbo].[Orders] ([ID], [State], [Customer_ID], [Supplier_ID]) VALUES (1, N'Pending', 1, 1)
INSERT [dbo].[Orders] ([ID], [State], [Customer_ID], [Supplier_ID]) VALUES (2, N'Confirmed', 2, 2)
INSERT [dbo].[Orders] ([ID], [State], [Customer_ID], [Supplier_ID]) VALUES (3, N'Shipped', 3, 3)
INSERT [dbo].[Orders] ([ID], [State], [Customer_ID], [Supplier_ID]) VALUES (4, N'Delivered', 4, 4)
INSERT [dbo].[Orders] ([ID], [State], [Customer_ID], [Supplier_ID]) VALUES (5, N'Pending', 5, 5)
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [Type], [Quantity], [Price], [Image], [Inventory_ID]) VALUES (1, N'Product 1', N'Description of Product 1', N'Type 1', 10, 100, NULL, 1)
INSERT [dbo].[Product] ([ID], [Name], [Description], [Type], [Quantity], [Price], [Image], [Inventory_ID]) VALUES (2, N'Product 2', N'Description of Product 2', N'Type 2', 20, 200, NULL, 2)
INSERT [dbo].[Product] ([ID], [Name], [Description], [Type], [Quantity], [Price], [Image], [Inventory_ID]) VALUES (3, N'Product 3', N'Description of Product 3', N'Type 3', 30, 300, NULL, 3)
INSERT [dbo].[Product] ([ID], [Name], [Description], [Type], [Quantity], [Price], [Image], [Inventory_ID]) VALUES (4, N'Product 4', N'Description of Product 4', N'Type 1', 40, 400, NULL, 1)
INSERT [dbo].[Product] ([ID], [Name], [Description], [Type], [Quantity], [Price], [Image], [Inventory_ID]) VALUES (5, N'Product 5', N'Description of Product 5', N'Type 2', 50, 500, NULL, 2)
GO
INSERT [dbo].[Role] ([ID], [Name], [Phone], [Email], [Type]) VALUES (1, N'Manager 1', N'111-111-1111', N'manager1@example.com', N'manager')
INSERT [dbo].[Role] ([ID], [Name], [Phone], [Email], [Type]) VALUES (2, N'Manager 2', N'222-222-2222', N'manager2@example.com', N'manager')
INSERT [dbo].[Role] ([ID], [Name], [Phone], [Email], [Type]) VALUES (3, N'Staff 1', N'333-333-3333', N'staff1@example.com', N'staff')
INSERT [dbo].[Role] ([ID], [Name], [Phone], [Email], [Type]) VALUES (4, N'Staff 2', N'444-444-4444', N'staff2@example.com', N'staff')
INSERT [dbo].[Role] ([ID], [Name], [Phone], [Email], [Type]) VALUES (5, N'Staff 3', N'555-555-5555', N'staff3@example.com', N'staff')
GO
INSERT [dbo].[Supplier] ([ID], [Name], [Phone], [Email], [Address]) VALUES (1, N'Supplier 1', N'111-111-1111', N'supplier1@example.com', N'123 Supplier St')
INSERT [dbo].[Supplier] ([ID], [Name], [Phone], [Email], [Address]) VALUES (2, N'Supplier 2', N'222-222-2222', N'supplier2@example.com', N'456 Supplier Ave')
INSERT [dbo].[Supplier] ([ID], [Name], [Phone], [Email], [Address]) VALUES (3, N'Supplier 3', N'333-333-3333', N'supplier3@example.com', N'789 Supplier Rd')
INSERT [dbo].[Supplier] ([ID], [Name], [Phone], [Email], [Address]) VALUES (4, N'Supplier 4', N'444-444-4444', N'supplier4@example.com', N'101 Supplier Blvd')
INSERT [dbo].[Supplier] ([ID], [Name], [Phone], [Email], [Address]) VALUES (5, N'Supplier 5', N'555-555-5555', N'supplier5@example.com', N'202 Supplier Ln')
INSERT [dbo].[Supplier] ([ID], [Name], [Phone], [Email], [Address]) VALUES (6, N'Supplier 6', N'666-666-6666', N'supplier6@example.com', N'303 Supplier Dr')
INSERT [dbo].[Supplier] ([ID], [Name], [Phone], [Email], [Address]) VALUES (7, N'Supplier 7', N'777-777-7777', N'supplier7@example.com', N'404 Supplier Way')
INSERT [dbo].[Supplier] ([ID], [Name], [Phone], [Email], [Address]) VALUES (8, N'Supplier 8', N'888-888-8888', N'supplier8@example.com', N'505 Supplier Ct')
INSERT [dbo].[Supplier] ([ID], [Name], [Phone], [Email], [Address]) VALUES (9, N'Supplier 9', N'999-999-9999', N'supplier9@example.com', N'606 Supplier Pl')
INSERT [dbo].[Supplier] ([ID], [Name], [Phone], [Email], [Address]) VALUES (10, N'Supplier 10', N'000-000-0000', N'supplier10@example.com', N'707 Supplier Cir')
GO
INSERT [dbo].[Transactions] ([ID], [Type], [Amount], [Order_ID], [Role_ID]) VALUES (1, N'Sale', 100, 1, 1)
INSERT [dbo].[Transactions] ([ID], [Type], [Amount], [Order_ID], [Role_ID]) VALUES (2, N'Sale', 200, 2, 2)
INSERT [dbo].[Transactions] ([ID], [Type], [Amount], [Order_ID], [Role_ID]) VALUES (3, N'Sale', 300, 3, 3)
INSERT [dbo].[Transactions] ([ID], [Type], [Amount], [Order_ID], [Role_ID]) VALUES (4, N'Sale', 400, 4, 4)
INSERT [dbo].[Transactions] ([ID], [Type], [Amount], [Order_ID], [Role_ID]) VALUES (5, N'Sale', 500, 5, 5)
GO
ALTER TABLE [dbo].[Delivery]  WITH CHECK ADD FOREIGN KEY([Order_ID])
REFERENCES [dbo].[Orders] ([ID])
GO
ALTER TABLE [dbo].[Inventory]  WITH CHECK ADD FOREIGN KEY([Order_ID])
REFERENCES [dbo].[Orders] ([ID])
GO
ALTER TABLE [dbo].[Order_Item]  WITH CHECK ADD FOREIGN KEY([Order_ID])
REFERENCES [dbo].[Orders] ([ID])
GO
ALTER TABLE [dbo].[Order_Item]  WITH CHECK ADD FOREIGN KEY([Product_ID])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([Customer_ID])
REFERENCES [dbo].[Customer] ([ID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([Supplier_ID])
REFERENCES [dbo].[Supplier] ([ID])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([Inventory_ID])
REFERENCES [dbo].[Inventory] ([ID])
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD FOREIGN KEY([Order_ID])
REFERENCES [dbo].[Orders] ([ID])
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD FOREIGN KEY([Role_ID])
REFERENCES [dbo].[Role] ([ID])
GO
USE [master]
GO
ALTER DATABASE [Warehouses_project] SET  READ_WRITE 
GO
