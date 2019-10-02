CREATE TABLE [dbo].[ManagerDepartment] (
    [ManagerDepartmentID] INT IDENTITY (1, 1) NOT NULL,
    [ManagerID]           INT NULL,
    [DepartmentID]        INT NULL,
    PRIMARY KEY CLUSTERED ([ManagerDepartmentID] ASC),
    FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[Department] ([DepartmentID]),
    FOREIGN KEY ([ManagerID]) REFERENCES [dbo].[Manager] ([ManagerID])
);

