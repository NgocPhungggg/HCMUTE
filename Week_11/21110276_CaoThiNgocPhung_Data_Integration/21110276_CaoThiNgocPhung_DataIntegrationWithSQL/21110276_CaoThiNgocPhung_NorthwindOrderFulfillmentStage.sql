-- Stage bảng OrderFulfillment
SELECT ProductID,
	   D.OrderID,
	   OrderDate,
	   ShippedDate
INTO [NorthwindSalesDWStage].[dbo].[NorthwindStageOrderFulfillment]
FROM [Northwind].[dbo].[Order Details] D
	JOIN [Northwind].[dbo].[Orders] O ON O.[OrderID] = D.[OrderID]
