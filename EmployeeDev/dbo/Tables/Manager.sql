CREATE TABLE [dbo].[Manager] (
    [ManagerID]    INT          IDENTITY (1, 1) NOT NULL,
    [ManagerName]  VARCHAR (50) NOT NULL,
    [DepartmentID] INT          NULL,
    PRIMARY KEY CLUSTERED ([ManagerID] ASC),
    FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[Department] ([DepartmentID]) ON DELETE CASCADE
);

