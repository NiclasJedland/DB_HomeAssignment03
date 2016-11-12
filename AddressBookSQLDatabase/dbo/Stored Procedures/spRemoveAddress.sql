
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spRemoveAddress] 
	-- Add the parameters for the stored procedure here
	@ContactAddress int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	DELETE FROM ContactAdress
		WHERE @ContactAddress = ContactAdressId
		--WHERE @AddressId = AdressId 
		--AND @ContactId = ContactId
END

