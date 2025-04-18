USE [master]
GO
/****** Object:  Database [Restaurant]    Script Date: 1/23/2025 11:58:39 AM ******/
CREATE DATABASE [Restaurant]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Restaurant', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\RESTAURANT.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Restaurant_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\RESTAURANT_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Restaurant] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Restaurant].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Restaurant] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Restaurant] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Restaurant] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Restaurant] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Restaurant] SET ARITHABORT OFF 
GO
ALTER DATABASE [Restaurant] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Restaurant] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Restaurant] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Restaurant] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Restaurant] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Restaurant] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Restaurant] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Restaurant] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Restaurant] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Restaurant] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Restaurant] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Restaurant] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Restaurant] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Restaurant] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Restaurant] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Restaurant] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Restaurant] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Restaurant] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Restaurant] SET  MULTI_USER 
GO
ALTER DATABASE [Restaurant] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Restaurant] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Restaurant] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Restaurant] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Restaurant]
GO
/****** Object:  Table [dbo].[MenuCategories]    Script Date: 1/23/2025 11:58:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuCategories](
	[CategoryID] [varchar](50) NOT NULL,
	[CategoryName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_MenuCategories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuItems]    Script Date: 1/23/2025 11:58:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuItems](
	[ItemID] [varchar](50) NOT NULL,
	[Item] [varchar](50) NOT NULL,
	[CategoryID] [varchar](50) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItems]    Script Date: 1/23/2025 11:58:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItems](
	[OrderID] [int] NOT NULL,
	[ItemName] [varchar](50) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Quantity] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 1/23/2025 11:58:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[TableNumber] [int] NOT NULL,
	[TotalPrice] [decimal](10, 2) NOT NULL,
	[OrderDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 1/23/2025 11:58:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[SaleID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[AmountPaid] [decimal](10, 2) NOT NULL,
	[PaymentMethod] [varchar](50) NOT NULL,
	[PaymentDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tables]    Script Date: 1/23/2025 11:58:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tables](
	[TableID] [int] NOT NULL,
	[TableNumber] [varchar](50) NOT NULL,
	[MaxCapacity] [int] NOT NULL,
	[Status] [varchar](50) NULL,
 CONSTRAINT [PK_Tables] PRIMARY KEY CLUSTERED 
(
	[TableID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 1/23/2025 11:58:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [varchar](50) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Role] [varchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[MenuCategories] ([CategoryID], [CategoryName]) VALUES (N'231', N'Food')
INSERT [dbo].[MenuCategories] ([CategoryID], [CategoryName]) VALUES (N'452', N'Drinks')
INSERT [dbo].[MenuCategories] ([CategoryID], [CategoryName]) VALUES (N'557', N'Desserts')
GO
INSERT [dbo].[MenuItems] ([ItemID], [Item], [CategoryID], [Price]) VALUES (N'4535', N'Pasta', N'231', CAST(110 AS Decimal(18, 0)))
INSERT [dbo].[MenuItems] ([ItemID], [Item], [CategoryID], [Price]) VALUES (N'7664', N'Fried Rice', N'231', CAST(90 AS Decimal(18, 0)))
INSERT [dbo].[MenuItems] ([ItemID], [Item], [CategoryID], [Price]) VALUES (N'7563', N'Cola', N'452', CAST(20 AS Decimal(18, 0)))
INSERT [dbo].[MenuItems] ([ItemID], [Item], [CategoryID], [Price]) VALUES (N'8954', N'Brownie', N'557', CAST(60 AS Decimal(18, 0)))
INSERT [dbo].[MenuItems] ([ItemID], [Item], [CategoryID], [Price]) VALUES (N'2456', N'Lemonade', N'452', CAST(25 AS Decimal(18, 0)))
INSERT [dbo].[MenuItems] ([ItemID], [Item], [CategoryID], [Price]) VALUES (N'8742', N'Burger', N'231', CAST(140 AS Decimal(18, 0)))
INSERT [dbo].[MenuItems] ([ItemID], [Item], [CategoryID], [Price]) VALUES (N'4682', N'Water', N'452', CAST(15 AS Decimal(18, 0)))
INSERT [dbo].[MenuItems] ([ItemID], [Item], [CategoryID], [Price]) VALUES (N'9087', N'Pastry', N'557', CAST(80 AS Decimal(18, 0)))
INSERT [dbo].[MenuItems] ([ItemID], [Item], [CategoryID], [Price]) VALUES (N'4257', N'Sandwich', N'231', CAST(50 AS Decimal(18, 0)))
GO
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (1, N'Fried Rice', CAST(90 AS Decimal(18, 0)), 1)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (1, N'Pastry', CAST(80 AS Decimal(18, 0)), 1)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (2, N'Lemonade', CAST(25 AS Decimal(18, 0)), 1)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (2, N'Fried Rice', CAST(90 AS Decimal(18, 0)), 1)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (5, N'Lemonade', CAST(25 AS Decimal(18, 0)), 1)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (5, N'Pastry', CAST(80 AS Decimal(18, 0)), 1)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (7, N'Pastry', CAST(80 AS Decimal(18, 0)), 1)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (8, N'Brownie', CAST(60 AS Decimal(18, 0)), 2)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (8, N'Fried Rice', CAST(90 AS Decimal(18, 0)), 1)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (9, N'Fried Rice', CAST(90 AS Decimal(18, 0)), 1)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (9, N'Burger', CAST(140 AS Decimal(18, 0)), 2)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (9, N'Cola', CAST(20 AS Decimal(18, 0)), 1)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (9, N'Water', CAST(15 AS Decimal(18, 0)), 1)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (9, N'Pastry', CAST(80 AS Decimal(18, 0)), 2)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (10, N'Burger', CAST(140 AS Decimal(18, 0)), 3)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (10, N'Lemonade', CAST(25 AS Decimal(18, 0)), 3)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (2, N'Pastry', CAST(80 AS Decimal(18, 0)), 1)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (3, N'Pasta', CAST(110 AS Decimal(18, 0)), 1)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (4, N'Lemonade', CAST(25 AS Decimal(18, 0)), 1)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (6, N'Pasta', CAST(110 AS Decimal(18, 0)), 1)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (6, N'Fried Rice', CAST(90 AS Decimal(18, 0)), 1)
INSERT [dbo].[OrderItems] ([OrderID], [ItemName], [Price], [Quantity]) VALUES (11, N'Pastry', CAST(80 AS Decimal(18, 0)), 3)
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderID], [TableNumber], [TotalPrice], [OrderDate]) VALUES (2, 4, CAST(195.00 AS Decimal(10, 2)), CAST(N'2025-01-22' AS Date))
INSERT [dbo].[Orders] ([OrderID], [TableNumber], [TotalPrice], [OrderDate]) VALUES (3, 3, CAST(110.00 AS Decimal(10, 2)), CAST(N'2025-01-22' AS Date))
INSERT [dbo].[Orders] ([OrderID], [TableNumber], [TotalPrice], [OrderDate]) VALUES (4, 6, CAST(25.00 AS Decimal(10, 2)), CAST(N'2025-01-22' AS Date))
INSERT [dbo].[Orders] ([OrderID], [TableNumber], [TotalPrice], [OrderDate]) VALUES (5, 4, CAST(105.00 AS Decimal(10, 2)), CAST(N'2025-01-22' AS Date))
INSERT [dbo].[Orders] ([OrderID], [TableNumber], [TotalPrice], [OrderDate]) VALUES (6, 1, CAST(200.00 AS Decimal(10, 2)), CAST(N'2025-01-22' AS Date))
INSERT [dbo].[Orders] ([OrderID], [TableNumber], [TotalPrice], [OrderDate]) VALUES (7, 1, CAST(80.00 AS Decimal(10, 2)), CAST(N'2025-01-22' AS Date))
INSERT [dbo].[Orders] ([OrderID], [TableNumber], [TotalPrice], [OrderDate]) VALUES (8, 5, CAST(210.00 AS Decimal(10, 2)), CAST(N'2025-01-23' AS Date))
INSERT [dbo].[Orders] ([OrderID], [TableNumber], [TotalPrice], [OrderDate]) VALUES (9, 5, CAST(565.00 AS Decimal(10, 2)), CAST(N'2025-01-23' AS Date))
INSERT [dbo].[Orders] ([OrderID], [TableNumber], [TotalPrice], [OrderDate]) VALUES (10, 6, CAST(495.00 AS Decimal(10, 2)), CAST(N'2025-01-23' AS Date))
INSERT [dbo].[Orders] ([OrderID], [TableNumber], [TotalPrice], [OrderDate]) VALUES (11, 2, CAST(240.00 AS Decimal(10, 2)), CAST(N'2025-01-23' AS Date))
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Sales] ON 

INSERT [dbo].[Sales] ([SaleID], [OrderID], [AmountPaid], [PaymentMethod], [PaymentDate]) VALUES (1, 2, CAST(195.00 AS Decimal(10, 2)), N'Cash', CAST(N'2025-01-22' AS Date))
INSERT [dbo].[Sales] ([SaleID], [OrderID], [AmountPaid], [PaymentMethod], [PaymentDate]) VALUES (2, 3, CAST(110.00 AS Decimal(10, 2)), N'Nagad', CAST(N'2025-01-22' AS Date))
INSERT [dbo].[Sales] ([SaleID], [OrderID], [AmountPaid], [PaymentMethod], [PaymentDate]) VALUES (3, 4, CAST(25.00 AS Decimal(10, 2)), N'Cash', CAST(N'2025-01-22' AS Date))
INSERT [dbo].[Sales] ([SaleID], [OrderID], [AmountPaid], [PaymentMethod], [PaymentDate]) VALUES (4, 5, CAST(105.00 AS Decimal(10, 2)), N'Card', CAST(N'2025-01-22' AS Date))
INSERT [dbo].[Sales] ([SaleID], [OrderID], [AmountPaid], [PaymentMethod], [PaymentDate]) VALUES (5, 6, CAST(200.00 AS Decimal(10, 2)), N'Nagad', CAST(N'2025-01-22' AS Date))
INSERT [dbo].[Sales] ([SaleID], [OrderID], [AmountPaid], [PaymentMethod], [PaymentDate]) VALUES (6, 7, CAST(80.00 AS Decimal(10, 2)), N'bKash', CAST(N'2025-01-22' AS Date))
INSERT [dbo].[Sales] ([SaleID], [OrderID], [AmountPaid], [PaymentMethod], [PaymentDate]) VALUES (7, 8, CAST(210.00 AS Decimal(10, 2)), N'Nagad', CAST(N'2025-01-23' AS Date))
INSERT [dbo].[Sales] ([SaleID], [OrderID], [AmountPaid], [PaymentMethod], [PaymentDate]) VALUES (8, 9, CAST(565.00 AS Decimal(10, 2)), N'Cash', CAST(N'2025-01-23' AS Date))
INSERT [dbo].[Sales] ([SaleID], [OrderID], [AmountPaid], [PaymentMethod], [PaymentDate]) VALUES (9, 10, CAST(495.00 AS Decimal(10, 2)), N'bKash', CAST(N'2025-01-23' AS Date))
INSERT [dbo].[Sales] ([SaleID], [OrderID], [AmountPaid], [PaymentMethod], [PaymentDate]) VALUES (10, 11, CAST(240.00 AS Decimal(10, 2)), N'Card', CAST(N'2025-01-23' AS Date))
SET IDENTITY_INSERT [dbo].[Sales] OFF
GO
INSERT [dbo].[Tables] ([TableID], [TableNumber], [MaxCapacity], [Status]) VALUES (1, N'1', 4, N'Occupied')
INSERT [dbo].[Tables] ([TableID], [TableNumber], [MaxCapacity], [Status]) VALUES (2, N'2', 6, N'Available')
INSERT [dbo].[Tables] ([TableID], [TableNumber], [MaxCapacity], [Status]) VALUES (3, N'3', 4, N'Reserved')
INSERT [dbo].[Tables] ([TableID], [TableNumber], [MaxCapacity], [Status]) VALUES (4, N'4', 8, N'Occupied')
INSERT [dbo].[Tables] ([TableID], [TableNumber], [MaxCapacity], [Status]) VALUES (5, N'5', 2, N'Available')
INSERT [dbo].[Tables] ([TableID], [TableNumber], [MaxCapacity], [Status]) VALUES (6, N'6', 4, N'Reserved')
INSERT [dbo].[Tables] ([TableID], [TableNumber], [MaxCapacity], [Status]) VALUES (7, N'7', 6, N'Available')
INSERT [dbo].[Tables] ([TableID], [TableNumber], [MaxCapacity], [Status]) VALUES (8, N'8', 8, N'Occupied')
INSERT [dbo].[Tables] ([TableID], [TableNumber], [MaxCapacity], [Status]) VALUES (9, N'9', 4, N'Reserved')
GO
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Role]) VALUES (N'USR-1', N'John', N'1234', N'Admin')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Role]) VALUES (N'USR-2', N'Kenneth', N'1234', N'Staff')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Role]) VALUES (N'USR-3', N'Misa', N'1234', N'Staff')
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (getdate()) FOR [OrderDate]
GO
ALTER TABLE [dbo].[MenuItems]  WITH CHECK ADD  CONSTRAINT [FK_MenuItems_MenuCategories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[MenuCategories] ([CategoryID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MenuItems] CHECK CONSTRAINT [FK_MenuItems_MenuCategories]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
USE [master]
GO
ALTER DATABASE [Restaurant] SET  READ_WRITE 
GO
