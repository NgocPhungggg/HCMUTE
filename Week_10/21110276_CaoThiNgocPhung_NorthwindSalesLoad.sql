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
