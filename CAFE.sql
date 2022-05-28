USE [CAFE]
GO

CREATE TABLE dbo.Product
	([productId] [bigint] IDENTITY (001,1),
	[productName] [nvarchar] (100),
	[stock] [int],		
	[price] [int]
	PRIMARY KEY (productId))
ON [PRIMARY]
GO

INSERT INTO dbo.Product
	([productName],
	 [stock],    
	 [price])

	 
VALUES
	/*CAFE DRINKS*/
	('Original Blend Coffee','100','79'),
	('Dark Roast Coffee','100','79'),
	('French Vanilla Latte','100','110'),	
	('Iced Coffee','100','95'),	
	('Capuccino','100','105'),
	('Flat White','100','137'),
	('Iced Latte','100','149'),	
	('Mocha Frapuccino','100','149'),	
	('Hot Chocolate','100','129'),
	('Espresso','100','149'),
	('Frozen Hot Chocolate','100','149'),
	('Strawberry-Banana Fruit Smoothie','100','134'),	
	('Mango and Passion Fruit Smoothie','100','134'),	
	('Caramel Macchiato','100','159'),
	('Cookie Crumble Macchiato Frappe','100','159'),
	
	/*DOUGHNUTS*/
	('Oh Nuts!','100','42'),
	('White Chocolate','100','45'),
	('Tira Miss U','100','43'),
	('Blueberry Cheesecake','100','43'),
	('Kinda Hot Dough','100','38'),
	('Honey Nuts','100','42'),
	('Chocolate','100','38'),
	('Jacky Chonk','100','42'),
	('Drew Berrymore','100','10'),
	('Birthday Cake','100','10'),
	('Forest Gump','100','10'),
	('Cinnamon Sugar','100','10'),
	('Holey Moley!','100','10'),

	/*MISC ITEMS*/
	('DDDCafe Tumbler','500','1500'),
	('DDDCafe Mugs','500','500'),
	('DDDCafe Planner','300','700'),
	('DDDCafe Tote Bags','500','1000'),
	('DDDCafe Reusable Cups','500','600')

GO

CREATE TABLE dbo.Cashier
	([cashierId] [bigint] IDENTITY (2020001,1) NOT NULL,
	[cashierName] [nvarchar] (50),
	[cashierLastName] [nvarchar] (50),
	[cashierStatus] [nvarchar] (50),
	[dateStarted] [date]
	PRIMARY KEY (cashierId))
	ON [PRIMARY]
GO

INSERT INTO dbo.Cashier
	([cashierName], 
	[cashierLastName],
	[cashierStatus], 
	[dateStarted])

VALUES
	('Jamaica Joy', 'ANGELO','On Duty', '12/05/2020'),
	('Jene Reiner', 'BOREJON','Off Duty', '12/05/2020'),
	('Angela Shanine', 'ESCOBAR','Off Duty', '12/05/2020'),
	('Nicole Anne', 'GUZMAN','On Duty', '12/05/2020')
GO

CREATE TABLE dbo.Receipt
	([receiptId] [bigint] IDENTITY (00001,1),
	[cashierId] [bigint] FOREIGN KEY REFERENCES dbo.Cashier(cashierId),
	[total] [decimal] (10,2),
	[dateOfPurchase] [date],
	[amountReceive] [decimal] (10,2),
	[change] [decimal] (10,2),
	PRIMARY KEY (receiptId))
	ON [PRIMARY]
GO

CREATE TABLE dbo.Orders
	([orderId] [bigint] IDENTITY (001,1),	
	[productId] [bigint] FOREIGN KEY REFERENCES dbo.Product(productId),
	[receiptId] [bigint] FOREIGN KEY REFERENCES dbo.Receipt(receiptId),
	[quantity] [int],
	[subtotal] [decimal] (10,2)
	PRIMARY KEY (orderId))
	ON [PRIMARY]
GO