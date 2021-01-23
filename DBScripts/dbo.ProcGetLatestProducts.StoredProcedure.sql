USE [MobileSiteDatabase]
GO
/****** Object:  StoredProcedure [dbo].[ProcGetLatestProducts]    Script Date: 17-01-2021 01:48:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[ProcGetLatestProducts]



AS
begin
select top 4 
ProductId,ProductName,SellingPrice,OperatingSystem,SecondImage  from ProductInformation order by  DateOfInsert desc  
end
