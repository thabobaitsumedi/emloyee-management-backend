CREATE TABLE [dbo].[Job] (
    [JobID]    INT          IDENTITY (1, 1) NOT NULL,
    [JobTitle] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([JobID] ASC)
);

