﻿CREATE TABLE [dbo].[TBParceiros] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Parceiro] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_TBParceiros] PRIMARY KEY CLUSTERED ([Id] ASC)
);

