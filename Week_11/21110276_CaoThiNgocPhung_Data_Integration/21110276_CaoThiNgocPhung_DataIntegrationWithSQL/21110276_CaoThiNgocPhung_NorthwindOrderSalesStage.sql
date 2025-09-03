-- Staging bảng Customers 
SELECT CustomerID, 
	   CompanyName, 
	   ContactName, 
	   ContactTitle, 
	   Address, 
	   City, 
	   Region, 
	   PostalCode, 
	   Country 
INTO [NorthwindSalesDWStage].[dbo].[NorthwindStageCustomers] 
FROM [Northwind].[dbo].[Customers]

-- Staging bảng Employees 
SELECT EmployeeID, 
	   FirstName, 
	   LastName, 
	   Title 
INTO [NorthwindSalesDWStage].[dbo].[NorthwindStageEmployees] 
FROM [Northwind].[dbo].[Employees] 

-- Staging bảng Products 
SELECT ProductID, 
	   ProductName,
	   Discontinued, 
	   CompanyName, 
	   CategoryName 
INTO [NorthwindSalesDWStage].[dbo].[NorthwindStageProducts] 
FROM [Northwind].[dbo].[Products] P 
	 JOIN [Northwind].[dbo].[Suppliers] S on P.[SupplierID] = S.[SupplierID] 
	 JOIN [Northwind].[dbo].[Categories] C on C.[CategoryID] = P.[CategoryID]

-- Staging bảng Date 
SELECT min(OrderDate) As StartOrderDate, 
	   max(OrderDate) As EndOrderDate, 
	   min(ShippedDate) As StartShippedDate, 
	   min(ShippedDate) As EndShippedDate 
FROM [Northwind].[dbo].[Orders] 

-- Tạo một database 'Temp' để chứa tạm dữ liệu'
CREATE TABLE Date_Dimension (date_key int not null,
							 full_date datetime,
							 day_of_week int,
							 day_num_in_month int,
							 day_num_overall int,
							 day_name varchar(9),
							 day_abbrev char(3),
							 weekday_flag char(20),
							 week_num_in_year int,
							 week_num_overall int,
							 week_begin_date datetime,
							 week_begin_date_key int,
							 month int,
							 month_num_overall int,
							 month_name varchar(9),
							 month_abbrev char(3),
							 quarter int,
							 year int,
							 yearmo int,
							 fiscal_month int,
							 fiscal_quarter int,
							 fiscal_year int,
							 last_day_in_month_flag char(20),
							 same_day_year_ago_date datetime,
							 primary key(date_key));
-- sau đó insert dữ liệu ở file Ch3-SampleDateDim.xls trên web 
-- (https://www.kimballgroup.com/data-warehouse-business-intelligenceresources/books/data-warehouse-dw-toolkit/)
-- có tải file về và tạo file scrip ở tuần

SELECT * 
INTO [NorthwindSalesDWStage].[dbo].[NorthwindStageDate] 
FROM [Temp].[dbo].[Date_Dimension] 
WHERE year between 1996 and 1998

-- Staging bảng Sales 
SELECT ProductID, 
	   od.OrderID, 
	   CustomerID, 
	   EmployeeID, 
	   OrderDate, 
	   ShippedDate, 
	   UnitPrice, 
	   Quantity, 
	   Discount 
INTO [NorthwindSalesDWStage].[dbo].[NorthwindStageSales] 
FROM [Northwind].[dbo].[Order Details] OD 
	 JOIN [Northwind].[dbo].[Orders] O ON OD.OrderID = O.OrderID 