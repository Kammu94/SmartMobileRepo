USE [MobileSiteDatabase]
GO
/****** Object:  StoredProcedure [dbo].[ProcInsertProducts]    Script Date: 17-01-2021 01:51:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[ProcInsertProducts](
@ProductId uniqueidentifier,
@ProductName nvarchar(50),
@SellingPrice decimal(18,3),
@MarketPrice decimal(18,3),
@Stock numeric(18,0),
@Description nvarchar(max),
@Rating numeric(5,0),
@OperatingSystem nvarchar(50),
@Color nvarchar(50),
@IsAvailable bit,
@FirstImage nvarchar(50),
@SecondImage nvarchar(50),
@ThirdImage nvarchar(50),
@FeatureType int,
@PageType int
)
AS
if exists(Select @ProductName from ProductInformation where ProductId=@ProductId)
begin
update	ProductInformation
set		ProductName=@ProductName ,
		SellingPrice=@SellingPrice,
		MarketPrice=@MarketPrice,
		Stock=@Stock,
		Description=@Description,
		Rating=@Rating,
		OperatingSystem=@OperatingSystem,
		Color=@Color,
		IsAvailable=@IsAvailable,
		FirstImage=@FirstImage,
		SecondImage=@SecondImage,
		ThirdImage=@ThirdImage,
		FeatureType=@FeatureType,
		PageType=@PageType
where	ProductId=@ProductId
end
else



begin
Insert into ProductInformation(ProductId,ProductName,SellingPrice,MarketPrice,Stock,Description,DateOfInsert,Rating,OperatingSystem,Color,IsAvailable,FirstImage,SecondImage,ThirdImage,FeatureType,PageType)
 values(newid(),@ProductName,@SellingPrice,@MarketPrice,@Stock,@Description,GETDATE(),@Rating,@OperatingSystem,@Color,@IsAvailable,@FirstImage,@SecondImage,@ThirdImage,@FeatureType,@PageType)
 end
