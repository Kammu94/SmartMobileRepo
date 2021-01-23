USE [MobileSiteDatabase]
GO
/****** Object:  StoredProcedure [dbo].[ProcGetProductList]    Script Date: 17-01-2021 01:49:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[ProcGetProductList]
as 
begin
select top 8 ProductName,SellingPrice,OperatingSystem,SecondImage from ProductInformation
end
