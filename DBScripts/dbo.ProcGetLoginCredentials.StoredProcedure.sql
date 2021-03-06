USE [MobileSiteDatabase]
GO
/****** Object:  StoredProcedure [dbo].[ProcGetLoginCredentials]    Script Date: 17-01-2021 01:48:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER proc [dbo].[ProcGetLoginCredentials]
@Email nvarchar(50),
@Password nvarchar(50)

As
declare @isValid bit,@Message nvarchar(200),@userId uniqueidentifier
Begin
if exists(Select 1 from SiteUser where Email=@Email)
begin  
		if (exists(Select 1 from SiteUser where Email=@Email and Password=@Password))
		begin
			

			select @isValid=1,@Message='Login Successfull',@userId=UserId from SiteUser

		
			
		end

		else
		begin
			select @isValid=0,@Message='Your Password was incorrect'
		end
end		 
else

begin

select @isValid=0,@Message='Invalid Email' 
end
		select @isValid as IsValid,@Message as [Message],@userId as UserId
END
