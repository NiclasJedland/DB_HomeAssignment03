﻿-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE spRemovePhoneNumber
	-- Add the parameters for the stored procedure here
	@ContactPhoneID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	DELETE FROM ContactPhone
		WHERE @ContactPhoneID = ContactPhoneId

END
