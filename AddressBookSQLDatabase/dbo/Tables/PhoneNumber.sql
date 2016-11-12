CREATE TABLE [dbo].[PhoneNumber] (
    [PhoneId] INT           IDENTITY (1, 1) NOT NULL,
    [Number]  NVARCHAR (50) NOT NULL,
    [Type]    NVARCHAR (50) NULL,
    CONSTRAINT [PK_PhoneNumber] PRIMARY KEY CLUSTERED ([PhoneId] ASC)
);

