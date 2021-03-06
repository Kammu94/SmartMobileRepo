USE [MobileSiteDatabase]
GO
/****** Object:  StoredProcedure [dbo].[ProcInsertSiteUserCredentials]    Script Date: 17-01-2021 01:51:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[ProcInsertSiteUserCredentials](
@UserId uniqueidentifier,
@FirstName nvarchar(50),
@LastName nvarchar(50),
@Email nvarchar(50) ,
@Password nvarchar(50),
@Gender nvarchar(50),
@Country nvarchar(50),
@ContactNumber numeric(18,0)



)

AS
declare @isValid bit,@Message nvarchar(200)
Begin

if (not exists(Select 1 from SiteUser where Email=@Email))
	begin
		Insert into SiteUser(UserId,FirstName,LastName,Email,Password,Gender,Country,ContactNumber)
		values(newid(),@FirstName,@LastName,@Email,@Password,@Gender,@Country,@ContactNumber)
	end
else
	begin
		select @isValid=1,@Message='This Email is already exists'
	end	
	
	select @isValid as isValid,@Message as [Message] 

END
