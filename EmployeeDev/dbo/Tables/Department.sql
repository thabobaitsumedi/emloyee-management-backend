CREATE TABLE [dbo].[Department] (
    [DepartmentID]   INT          IDENTITY (1, 1) NOT NULL,
    [DepartmentName] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([DepartmentID] ASC)
);

