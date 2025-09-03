--Load bảng OrderFulfillment
INSERT INTO [NorthwindSalesDW].dbo.[FactOrderFulfillment] (ProductKey,
														   OrderID,
														   OrderDateKey,
														   ShippedDateKey,
														   OrderToShippedLagInDays)
SELECT P.ProductKey, OrFul.OrderID,
	   Day(OrFul.OrderDate) + MONTH(OrFul.OrderDate) * 100 + YEAR(OrFul.OrderDate) * 10000 AS OrderDateKey,
	   CASE WHEN OrFul.ShippedDate IS NULL THEN -1
	   ELSE Day(OrFul.ShippedDate) + MONTH(OrFul.ShippedDate) * 100 + YEAR(OrFul.ShippedDate) * 10000 
	   END AS ShippedDateKey,
	   CASE WHEN DATEDIFF(day, OrFul.OrderDate, OrFul.ShippedDate) is null then -1
	   ELSE DATEDIFF(day, OrFul.OrderDate, OrFul.ShippedDate) 
	   END AS OrderToShippedLagInDays
FROM [NorthwindSalesDWStage].[dbo].[NorthwindStageOrderFulfillment] OrFul
	 JOIN [NorthwindSalesDW].[dbo].[DimProduct] P on OrFul.ProductID = P.ProductID
