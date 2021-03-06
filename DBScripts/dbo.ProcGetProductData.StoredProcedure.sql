USE [MobileSiteDatabase]
GO
/****** Object:  StoredProcedure [dbo].[ProcGetProductData]    Script Date: 17-01-2021 01:49:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[ProcGetProductData]
As
begin
Select ProductId,ProductName, SellingPrice,MarketPrice,Stock,Description,DateOfInsert,Rating,OperatingSystem,Color,IsAvailable,FirstImage,SecondImage,ThirdImage,FeatureType,PAgeType from ProductInformation 
order by DateOfInsert desc
end
