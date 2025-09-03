CREATE TABLE DimCustomer (
	CustomerKey  int IDENTITY NOT NULL
	-- attributes
, 	CustomerId  nvarchar(5)   NOT NULL
,  	CompanyName  nvarchar(40) NOT NULL
,  	ContactName  nvarchar(30) NOT NULL
,  	ContactTitle  nvarchar(30) NOT NULL
,  	CustomerCountry  nvarchar(15) NOT NULL
,  	CustomerRegion  nvarchar(15) DEFAULT 'N/A'  NOT NULL
,  	CustomerCity  nvarchar(15)   NOT NULL
,  	CustomerPostalCode  nvarchar(10)   NOT NULL
	-- metadata
,  	RowIsCurrent  bit DEFAULT 1 NOT NULL
,  	RowStartDate  datetime DEFAULT '12/31/1899' NOT NULL
,  	RowEndDate  datetime DEFAULT '12/31/9999' NOT NULL
,  	RowChangeReason  nvarchar(200) NULL
, CONSTRAINT PK_DimCustomer PRIMARY KEY (CustomerKey)
)


CREATE TABLE DimEmployee (
	EmployeeKey  int IDENTITY  NOT NULL
	-- attributes
,  	EmployeeId  int   NOT NULL
,  	EmployeeName	nvarchar(40) NOT NULL
,  	EmployeeTitle	nvarchar(30) NOT NULL
	-- metadata
,  	RowIsCurrent  bit   DEFAULT 1 NOT NULL
,  	RowStartDate  datetime  DEFAULT '12/31/1899' NOT NULL
,  	RowEndDate  datetime  DEFAULT '12/31/9999' NOT NULL
,  	RowChangeReason  nvarchar(200)   NULL
, CONSTRAINT PK_DimEmployee PRIMARY KEY (EmployeeKey)
)

CREATE TABLE DimProduct (
	ProductKey	int	IDENTITY NOT NULL
	-- attributes
,	ProductID	int	NOT NULL
,	ProductName	nvarchar(40) NOT NULL
,	Discontinued	nchar(1) default('N') NOT NULL
,	SupplierName	nvarchar(40) NOT NULL
,	CategoryName	nvarchar(15) NOT NULL
	-- metadata
,  	RowIsCurrent  bit DEFAULT 1 NOT NULL
,  	RowStartDate  datetime DEFAULT '12/31/1899' NOT NULL
,  	RowEndDate  datetime DEFAULT '12/31/9999' NOT NULL
,  	RowChangeReason  nvarchar(200) NOT NULL
, 	CONSTRAINT PK_DimProduct PRIMARY KEY (ProductKey)
)

CREATE TABLE DimDate(
	DateKey int NOT NULL,
	Date datetime NULL,
	DayOfWeek tinyint NOT NULL,
	DayName varchar(9) NOT NULL,
	DayOfMonth tinyint NOT NULL,
	DayOfYear smallint NOT NULL,
	WeekOfYear tinyint NOT NULL,
	MonthName varchar(9) NOT NULL,
	MonthOfYear tinyint NOT NULL,
	Quarter tinyint NOT NULL,
	--QuarterName nchar(10) NOT NULL,
	Year smallint NOT NULL,
	IsAWeekday varchar(1) NOT NULL DEFAULT (('N')),
	constraint PK_DimDate PRIMARY KEY (DateKey)
)

CREATE TABLE FactSales (
	ProductKey	int	NOT NULL
,	CustomerKey	int	NOT NULL
,	EmployeeKey	int NOT NULL
,	OrderDateKey int NOT NULL
,	ShippedDateKey int NULL
,	OrderID	int	NOT NULL
	-- measures
,	Quantity	smallint 	NOT NULL
,	ExtendedPriceAmount	decimal(25,4) NOT NULL
,	DiscountAmount	decimal(25,4)  DEFAULT 0 NOT NULL
,	SoldAmount	decimal(25,4)  NOT NULL
	-- constraints
, 	CONSTRAINT PK_FactSales PRIMARY KEY (ProductKey, OrderID)
,	CONSTRAINT FK_ProductKey FOREIGN KEY (ProductKey) REFERENCES DimProduct(ProductKey)
,	CONSTRAINT FK_CustomerKey FOREIGN KEY (CustomerKey) REFERENCES DimCustomer(CustomerKey)
,	CONSTRAINT FK_EmployeeKey FOREIGN KEY (EmployeeKey) REFERENCES DimEmployee(EmployeeKey)
,	CONSTRAINT FK_OrderDateKey FOREIGN KEY (OrderDateKey) REFERENCES DimDate(DateKey)
,	CONSTRAINT FK_ShippedDateKey FOREIGN KEY (ShippedDateKey) REFERENCES DimDate(DateKey)
)

/* Create table DimSupplier */
CREATE TABLE DimSupplier (
	SupplierKey  int IDENTITY  NOT NULL,
	SupplierID  nvarchar(10)   NOT NULL,
  	CompanyName  nvarchar(40) NOT NULL,
  	ContactName  nvarchar(30) NOT NULL,
  	ContactTitle  nvarchar(30) NOT NULL,
	SupplierCountry  nvarchar(15) NOT NULL,
  	SupplierRegion  nvarchar(15) DEFAULT 'N/A'  NOT NULL,
  	SupplierCity  nvarchar(15)   NOT NULL,
  	SupplierPostalCode  nvarchar(10)   NOT NULL,
	-- metadata
  	RowIsCurrent  bit DEFAULT 1 NOT NULL,
  	RowStartDate  datetime DEFAULT '12/31/1899' NOT NULL,
  	RowEndDate  datetime DEFAULT '12/31/9999' NOT NULL,
  	RowChangeReason  nvarchar(200) NULL,
	CONSTRAINT PK_DimSupplier PRIMARY KEY (SupplierKey)
) 


/* Create table FactInventory */
CREATE TABLE FactInventory (
	ProductKey  int   NOT NULL,
	SupplierKey  int  NOT NULL,
	OrderDateKey  int   NOT NULL,
	UnitsInStock  smallint   NULL,
	UnitsOnOrder  smallint  NULL,
	CONSTRAINT PK_FactInventory PRIMARY KEY (ProductKey, OrderDateKey),
	CONSTRAINT FK_FactInventoryt_DateKey FOREIGN KEY(OrderDateKey) REFERENCES DimDate(DateKey),
	CONSTRAINT FK_FactInventoryt_SupplierKey FOREIGN KEY(SupplierKey) REFERENCES DimSupplier(SupplierKey),
	CONSTRAINT FK_FactInventory_ProductKey FOREIGN KEY (ProductKey) REFERENCES DimProduct(ProductKey)
)
