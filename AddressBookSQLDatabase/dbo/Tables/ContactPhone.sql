CREATE TABLE [dbo].[ContactPhone] (
    [ContactPhoneId] INT IDENTITY (1, 1) NOT NULL,
    [ContactId]      INT NOT NULL,
    [PhoneId]        INT NOT NULL,
    CONSTRAINT [PK_ContactPhone] PRIMARY KEY CLUSTERED ([ContactPhoneId] ASC),
    CONSTRAINT [FK_ContactPhone_Contact] FOREIGN KEY ([ContactId]) REFERENCES [dbo].[Contact] ([ContactId]) ON DELETE CASCADE,
    CONSTRAINT [FK_ContactPhone_PhoneNumber] FOREIGN KEY ([PhoneId]) REFERENCES [dbo].[PhoneNumber] ([PhoneId]) ON DELETE CASCADE
);

