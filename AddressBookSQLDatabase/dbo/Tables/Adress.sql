CREATE TABLE [dbo].[Adress] (
    [AdressId] INT           IDENTITY (1, 1) NOT NULL,
    [Adress]   NVARCHAR (50) NOT NULL,
    [ZipCode]  NVARCHAR (50) NULL,
    [City]     NVARCHAR (50) NULL,
    [Country]  NVARCHAR (50) NULL,
    [Type]     NVARCHAR (50) NULL,
    CONSTRAINT [PK_Adress] PRIMARY KEY CLUSTERED ([AdressId] ASC)
);

