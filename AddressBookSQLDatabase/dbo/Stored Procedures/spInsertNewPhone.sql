-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE spInsertNewPhone
	-- Add the parameters for the stored procedure here
	@ContactId int
	,@Number nvarchar(50)
	,@Type nvarchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @PhoneId int

    INSERT INTO PhoneNumber(Number, Type)
		SELECT @Number, @Type

	SET @PhoneId = (SELECT MAX(PhoneId) FROM PhoneNumber)

	INSERT INTO ContactPhone(ContactId, PhoneId)
		SELECT @ContactId, @PhoneId


END
