--2. Staging 
--Staging bảng Customers 
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

--Staging bảng Employees 
SELECT EmployeeID, 
	   FirstName, 
	   LastName, 
	   Title 
INTO [NorthwindSalesDWStage].[dbo].[NorthwindStageEmployees] 
FROM [Northwind].[dbo].[Employees] 

--Staging bảng Products 
SELECT ProductID, 
	   ProductName,
	   Discontinued, 
	   CompanyName, 
	   CategoryName 
INTO [NorthwindSalesDWStage].[dbo].[NorthwindStageProducts] 
FROM [Northwind].[dbo].[Products] P 
	 JOIN [Northwind].[dbo].[Suppliers] S on P.[SupplierID] = S.[SupplierID] 
	 JOIN [Northwind].[dbo].[Categories] C on C.[CategoryID] = P.[CategoryID]

--Staging bảng Date 
SELECT min(OrderDate) As StartOrderDate, 
	   max(OrderDate) As EndOrderDate, 
	   min(ShippedDate) As StartShippedDate, 
	   min(ShippedDate) As EndShippedDate 
FROM [Northwind].[dbo].[Orders] 

--Tạo một database 'Temp' để chứa tạm dữ liệu'
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
--sau đó insert dữ liệu ở file Ch3-SampleDateDim.xls trên web 
--(https://www.kimballgroup.com/data-warehouse-business-intelligenceresources/books/data-warehouse-dw-toolkit/)
--có tải file về và tạo file scrip ở tuần

SELECT * 
INTO [NorthwindSalesDWStage].[dbo].[NorthwindStageDate] 
FROM [Temp].[dbo].[Date_Dimension] 
WHERE year between 1996 and 1998

--Staging fact table 
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
	 join [Northwind].[dbo].[Orders] O on OD.OrderID = O.OrderID 

--3. Load dữ liệu từ stage table vào data warehouse
--Load bảng DimCustomer 
INSERT INTO [NorthwindSalesDW].[dbo].[DimCustomer] (CustomerId, 
													CompanyName, 
													ContactName, 
													ContactTitle, 
													CustomerCountry, 
													CustomerRegion, 
													CustomerCity, 
													CustomerPostalCode)
SELECT CustomerID, 
	   CompanyName, 
	   ContactName, 
	   ContactTitle, 
	   Country, 
	   CASE WHEN Region IS NULL THEN 'N/A' ELSE Region END, 
	   City, 
	   CASE WHEN PostalCode IS NULL THEN 'N/A' ELSE PostalCode END
FROM [NorthwindSalesDWStage].[dbo].[NorthwindStageCustomers] 

--Load bảng DimEmployee 
INSERT INTO [NorthwindSalesDW].[dbo].[DimEmployee] (EmployeeId, 
													EmployeeName, 
													EmployeeTitle)
SELECT EmployeeId, 
	   FirstName + ' ' + LastName, 
	   Title 
FROM [NorthwindSalesDWStage].[dbo].[NorthwindStageEmployees] 

--Load bảng DimProduct 
INSERT INTO  [NorthwindSalesDW].[dbo].[DimProduct] (ProductID, 
													ProductName, 
													Discontinued, 
													SupplierName,
													CategoryName)
SELECT ProductID, 
	   ProductName, 
	   CASE WHEN Discontinued = 1 THEN 'Y' ELSE 'N' END, 
	   CompanyName,
	   CategoryName 
FROM [NorthwindSalesDWStage].[dbo].[NorthwindStageProducts] 

--Load bảng DimDate 
INSERT INTO [NorthwindSalesDW].[dbo].[DimDate] (DateKey, 
												Date, 
												DayOfWeek, 
												DayName, 
												DayOfMonth, 
												DayOfYear,
												WeekOfYear, 
												MonthName, 
												MonthOfYear, 
												Quarter, 
												QuarterName, 
												Year, 
												IsAWeekday)
SELECT date_key, 
	   full_date, 
	   day_of_week, 
	   day_name, 
	   day_num_in_month, 
	   day_num_overall, 
	   week_num_in_year, 
	   month_name, 
	   month, 
	   quarter,
	   CASE WHEN quarter >= 1 and quarter <= 3 THEN 'First'
			WHEN quarter >= 4 and quarter <= 6 THEN 'Second'
			WHEN quarter >= 7 and quarter <= 9 THEN 'Third'
			WHEN quarter >= 10 and quarter <= 12 THEN 'Fourth' END,
	   year, 
	   weekday_flag 
FROM NorthwindSalesDWStage.dbo.NorthwindStageDate

--Load bảng FactSales 
INSERT INTO [NorthwindSalesDW].[dbo].[FactSales] (ProductKey, 
												  CustomerKey, 
												  EmployeeKey, 
												  OrderDateKey, 
												  ShippedDateKey,
												  OrderID, 
												  Quantity, 
												  ExtendedPriceAmount, 
												  DiscountAmount, 
												  SoldAmount)
SELECT P.ProductKey, 
	   C.CustomerKey, 
	   E.EmployeeKey,
	   Day(S.OrderDate) + MONTH(s.OrderDate) * 100 + YEAR(s.OrderDate) * 10000 AS OrderDateKey,
	   CASE WHEN S.ShippedDate IS NULL THEN -1
	   ELSE Day(s.ShippedDate) + MONTH(s.ShippedDate) * 100 + YEAR(s.ShippedDate) * 10000 
	   END AS ShippedDateKey,
	   S.OrderID,
	   S.Quantity,
	   S.Quantity * S.UnitPrice as ExtendedPriceAmount,
	   S.Quantity * S.UnitPrice * S.Discount AS DiscountAmount, 
	   S.Quantity * S.UnitPrice * (1 - S.Discount) AS SoldAmount  
FROM [NorthwindSalesDWStage].[dbo].[NorthwindStageSales] S 
	 JOIN NorthwindSalesDW.dbo.DimCustomer C ON S.CustomerID = C.CustomerId 
	 JOIN NorthwindSalesDW.dbo.DimEmployee E ON S.EmployeeID = E.EmployeeId 
	 JOIN NorthwindSalesDW.dbo.DimProduct P ON S.ProductID = P.ProductID 

