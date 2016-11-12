-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertNewAddress]
	-- Add the parameters for the stored procedure here
	@ContactId int
	,@Address nvarchar(50)
	,@ZipCode nvarchar(50)
	,@City nvarchar(50)
	,@Country nvarchar(50)
	,@Type nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @AdressID int

    INSERT INTO Adress (Adress, ZipCode, City, Country, Type)
		SELECT @Address, @ZipCode, @City, @Country, @Type

	SET @AdressID = (SELECT MAX(AdressId) FROM Adress)

	INSERT INTO ContactAdress (ContactId, AdressId)
		SELECT @ContactId, @AdressID


END
