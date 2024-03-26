USE [Test]
GO

/****** Object: Table [dbo].[Users] Script Date: 26.03.2024 16:36:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users] (
    [Id]       INT        IDENTITY (1, 1) NOT NULL,
    [USERNAME] NCHAR (40) NULL,
    [PASSWORD] NCHAR (40) NULL
);


