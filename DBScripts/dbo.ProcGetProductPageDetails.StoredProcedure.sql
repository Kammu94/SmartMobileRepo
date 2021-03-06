USE [MobileSiteDatabase]
GO
/****** Object:  StoredProcedure [dbo].[ProcGetProductPageDetails]    Script Date: 17-01-2021 01:50:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[ProcGetProductPageDetails](

@ProductId uniqueidentifier
)
as
begin
	select ProductId, ProductName,SellingPrice,Color,OperatingSystem,Rating,SecondImage,[Description]
	from ProductInformation 
	where ProductId=@ProductId
end
