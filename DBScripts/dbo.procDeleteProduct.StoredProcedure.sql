USE [MobileSiteDatabase]
GO
/****** Object:  StoredProcedure [dbo].[ProcDeleteProduct]    Script Date: 17-01-2021 01:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[ProcDeleteProduct](
@ProductId uniqueidentifier
)
As
delete  from ProductInformation where ProductId=@ProductId
