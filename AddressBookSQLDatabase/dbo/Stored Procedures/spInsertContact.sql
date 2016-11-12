
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertContact]
	-- Add the parameters for the stored procedure here
	@Name nvarchar(50),
	@Number nvarchar(50),
	@PhoneType nvarchar(50),
	@Adress nvarchar (50),
	@ZipCode nvarchar (50),
	@City nvarchar (50),
	@Country nvarchar (50),
	@AdressType nvarchar (50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
		
		DECLARE @ContactId int
		DECLARE @AdressId int
		DECLARE @PhoneId int
		
		INSERT INTO Contact (Name)
			SELECT @Name

		INSERT INTO PhoneNumber(Number, Type)
			SELECT @Number, @PhoneType

		INSERT INTO Adress (Adress, ZipCode, City, Country, Type)
			SELECT  @Adress, @ZipCode, @City, @Country, @AdressType

		SET @ContactId = (SELECT MAX(ContactId) FROM Contact)
		SET @AdressId = (SELECT MAX(AdressId) FROM Adress)
		SET @PhoneId = (SELECT MAX(PhoneId) FROM PhoneNumber)

		INSERT INTO ContactAdress (ContactId, AdressId)
			SELECT @ContactId, @AdressId

		INSERT INTO ContactPhone (ContactId, PhoneId)
			SELECT @ContactId, @PhoneId
			
END

