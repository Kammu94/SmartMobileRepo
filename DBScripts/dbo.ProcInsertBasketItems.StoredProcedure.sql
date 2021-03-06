USE [MobileSiteDatabase]
GO
/****** Object:  StoredProcedure [dbo].[ProcInsertBasketItems]    Script Date: 17-01-2021 01:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[ProcInsertBasketItems](

@Email nvarchar(50),
@ProductId uniqueidentifier,
@Quantity int,
@UserId uniqueidentifier,
@Total int,
@BasketId uniqueidentifier,
@GrandTotal int

)
AS

	Declare @CartId uniqueidentifier
Begin
	If (Exists(Select 1 from UsersBasket where Email=@Email))
		Begin
			Select CartId=@BasketId from UsersBasket where Email=@Email

			Insert into UsersBasketItems(ItemId,ProductId,Quantity,BasketId,Total,DateOfCreation)
			values(newid(),@ProductId,@Quantity,@CartId,@Total,GETDATE())

			Select ProductName,SellingPrice,Quantity,SecondImage,Total 
			from ProductInformation  P left join UsersBasketItems U
			on P.ProductId=U.ProductId 
			End

	else

		Insert into UsersBasket(BasketId,UserId,Email,DateOfCreation,GrandTotal)
		values(newid(),@UserId,@Email,GETDATE(),@GrandTotal)

		Select ProductName,SellingPrice,Quantity,SecondImage,Total 
		from ProductInformation  P left join UsersBasketItems U
		on P.ProductId=U.ProductId 
End
		
		
