USE [MobileSiteDatabase]
GO
/****** Object:  StoredProcedure [dbo].[ProcGetProductListBulk]    Script Date: 17-01-2021 01:50:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[ProcGetProductListBulk]
as 
begin
select  ProductId, ProductName,SellingPrice,FeatureType,FirstImage,SecondImage,ThirdImage,MarketPrice,[Description],PageType from ProductInformation
order by dateOfinsert desc
end
