CREATE TABLE [dbo].[ContactAdress] (
    [ContactAdressId] INT IDENTITY (1, 1) NOT NULL,
    [ContactId]       INT NOT NULL,
    [AdressId]        INT NOT NULL,
    CONSTRAINT [PK_ContactAdress] PRIMARY KEY CLUSTERED ([ContactAdressId] ASC),
    CONSTRAINT [FK_ContactAdress_Adress] FOREIGN KEY ([AdressId]) REFERENCES [dbo].[Adress] ([AdressId]) ON DELETE CASCADE,
    CONSTRAINT [FK_ContactAdress_Contact] FOREIGN KEY ([ContactId]) REFERENCES [dbo].[Contact] ([ContactId]) ON DELETE CASCADE
);

