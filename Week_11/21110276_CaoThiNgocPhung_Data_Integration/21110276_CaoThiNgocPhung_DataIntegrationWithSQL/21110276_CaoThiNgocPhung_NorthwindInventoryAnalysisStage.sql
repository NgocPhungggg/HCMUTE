--Stage bảng Suppliers
SELECT SupplierID, 
	   CompanyName, 
	   ContactName, 
	   ContactTitle, 
	   Country,
	   Region, 
	   City, 
	   PostalCode
INTO [NorthwindSalesDWStage].[dbo].[NorthwindStageSuppliers] 
FROM [Northwind].[dbo].[Suppliers]

-- Stage bảng Inventory
SELECT P.ProductID, 
	   S.SupplierID, 
	   OrderDate, 
	   UnitsInStock, 
	   UnitsOnOrder
INTO [NorthwindSalesDWStage].[dbo].[NorthwindStageInventory] 
FROM [Northwind].[dbo].[Suppliers] S 
	 JOIN [Northwind].[dbo].[Products] P  ON S.SupplierID=P.SupplierID
	 JOIN [Northwind].[dbo].[Order Details] OD ON P.ProductID=OD.ProductID 
	 JOIN [Northwind].[dbo].[Orders] O on O.OrderID=OD.OrderID
