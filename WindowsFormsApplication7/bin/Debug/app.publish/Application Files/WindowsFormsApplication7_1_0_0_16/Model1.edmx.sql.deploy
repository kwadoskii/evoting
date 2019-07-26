
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/19/2016 11:17:36
-- Generated from EDMX file: C:\Users\Kwadoskii Noni\Documents\Visual Studio 2013\Projects\WindowsFormsApplication7\WindowsFormsApplication7\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [testdb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[admins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[admins];
GO
IF OBJECT_ID(N'[dbo].[voters]', 'U') IS NOT NULL
    DROP TABLE [dbo].[voters];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'admins'
CREATE TABLE [dbo].[admins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [surname] nvarchar(max)  NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [username] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'voters'
CREATE TABLE [dbo].[voters] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [surname] nvarchar(max)  NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [middleName] nvarchar(max)  NOT NULL,
    [sex] nvarchar(max)  NOT NULL,
    [phoneNo] nvarchar(max)  NOT NULL,
    [department] nvarchar(max)  NOT NULL,
    [regNo] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [image] nvarchar(max)  NOT NULL,
    [fingerPrint] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'candidates'
CREATE TABLE [dbo].[candidates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [surname] nvarchar(max)  NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [middlename] nvarchar(max)  NOT NULL,
    [image] nvarchar(max)  NOT NULL,
    [position] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'admins'
ALTER TABLE [dbo].[admins]
ADD CONSTRAINT [PK_admins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'voters'
ALTER TABLE [dbo].[voters]
ADD CONSTRAINT [PK_voters]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'candidates'
ALTER TABLE [dbo].[candidates]
ADD CONSTRAINT [PK_candidates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------