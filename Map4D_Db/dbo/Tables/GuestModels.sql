CREATE TABLE [dbo].[GuestModels] (
    [IdGuest]      INT            IDENTITY (1, 1) NOT NULL,
    [GuestName]    NVARCHAR (255) NOT NULL,
    [GuestEmail]   NVARCHAR (MAX) NOT NULL,
    [GuestSubject] NVARCHAR (MAX) NOT NULL,
    [Message]      NVARCHAR (MAX) NOT NULL,
    [DateUp]       DATETIME       NOT NULL,
    [Status]       BIT            DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_dbo.GuestModels] PRIMARY KEY CLUSTERED ([IdGuest] ASC)
);

