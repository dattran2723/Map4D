CREATE TABLE [dbo].[Customers] (
    [ID]           NVARCHAR (128) NOT NULL,
    [Name]         NVARCHAR (50)  NOT NULL,
    [Company]      NVARCHAR (MAX) NOT NULL,
    [Phone]        NVARCHAR (13)  NOT NULL,
    [Email]        NVARCHAR (MAX) NOT NULL,
    [RegisterDate] DATETIME       NOT NULL,
    [Description]  NVARCHAR (MAX) NULL,
    [Status]       BIT            NOT NULL,
    CONSTRAINT [PK_dbo.Customers] PRIMARY KEY CLUSTERED ([ID] ASC)
);

