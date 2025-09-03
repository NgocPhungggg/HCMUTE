-- Load bảng DimSupplier
INSERT INTO [NorthwindSalesDW].[dbo].[DimSupplier] (SupplierID, 
	CompanyName, 
	ContactName, 
	ContactTitle, 
	Country,						
	Region,						
	City, 						
	PostalCode)
SELECT SupplierID, 
	   CompanyName,
	   ContactName, 
	   ContactTitle, 
	   Country,
	   CASE WHEN Region is null then 'N/A' ELSE Region END,
	   City, 
	   PostalCode 
FROM [NorthwindSalesDWStage].[dbo].[NorthwindStageSuppliers]

-- Load bảng FactInventory
INSERT INTO [NorthwindSalesDW].[dbo].[FactInventoryAnalysis] (ProductKey, 
															  SupplierKey, 
															  OrderDateKey, 
															  UnitsInStock, 
															  UnitsOnOrder)
SELECT P.ProductID, 
	   SupplierKey, 
	   Day(Date) + MONTH(Date) * 100 + YEAR(Date) * 10000 AS OrderDateKey,
	   UnitsInStock, 
	   UnitsOnOrder
FROM [NorthwindSalesDWStage].[dbo].[NorthwindStageInventory] I
	 JOIN  [NorthwindSalesDW].[dbo].[DimProduct] P ON I.ProductID = P.ProductID
	 JOIN  [NorthwindSalesDW].[dbo].[DimSupplier] S ON I.SupplierID = S.SupplierKey
	 JOIN  [NorthwindSalesDW].[dbo].[DimDate] D ON I.OrderDate = Date
