CREATE TABLE [dbo].[Address] (
    [AddressID]     INT           IDENTITY (1, 1) NOT NULL,
    [Line1]         VARCHAR (255) NOT NULL,
    [Line2]         VARCHAR (255) NULL,
    [PostalCode]    INT           NOT NULL,
    [AddressTypeID] INT           NULL,
    PRIMARY KEY CLUSTERED ([AddressID] ASC),
    FOREIGN KEY ([AddressTypeID]) REFERENCES [dbo].[AddressType] ([AddressTypeID]) ON DELETE CASCADE
);

