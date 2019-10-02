CREATE TABLE [dbo].[AddressType] (
    [AddressTypeID]      INT           IDENTITY (1, 1) NOT NULL,
    [AddressDescription] VARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([AddressTypeID] ASC)
);

