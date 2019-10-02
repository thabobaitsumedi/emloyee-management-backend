CREATE TABLE [dbo].[Employee] (
    [EmployeeID]   UNIQUEIDENTIFIER DEFAULT (newsequentialid()) NOT NULL,
    [FirstName]    VARCHAR (MAX)    NOT NULL,
    [LastName]     VARCHAR (MAX)    NOT NULL,
    [DoB]          DATE             NOT NULL,
    [PhoneNumber]  VARCHAR (13)     NOT NULL,
    [EmailAddress] VARCHAR (MAX)    NOT NULL,
    [HireDate]     DATE             NOT NULL,
    [GenderID]     INT              NULL,
    [ManagerID]    INT              NULL,
    [JobID]        INT              NULL,
    [DepartmentID] INT              NULL,
    [AddressID]    INT              NULL,
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC),
    FOREIGN KEY ([AddressID]) REFERENCES [dbo].[Address] ([AddressID]),
    FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[Department] ([DepartmentID]),
    FOREIGN KEY ([GenderID]) REFERENCES [dbo].[Gender] ([GenderID]),
    FOREIGN KEY ([JobID]) REFERENCES [dbo].[Job] ([JobID]),
    FOREIGN KEY ([ManagerID]) REFERENCES [dbo].[Manager] ([ManagerID])
);

