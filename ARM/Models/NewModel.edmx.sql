
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/02/2016 14:14:52
-- Generated from EDMX file: D:\Практика\ARM\ARM\Models\NewModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ARMdatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ExtractServis]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Servises] DROP CONSTRAINT [FK_ExtractServis];
GO
IF OBJECT_ID(N'[dbo].[FK_RenterExtract]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Extracts] DROP CONSTRAINT [FK_RenterExtract];
GO
IF OBJECT_ID(N'[dbo].[FK_RenterPrivilege]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Privileges] DROP CONSTRAINT [FK_RenterPrivilege];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Extracts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Extracts];
GO
IF OBJECT_ID(N'[dbo].[Privileges]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Privileges];
GO
IF OBJECT_ID(N'[dbo].[Renters]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Renters];
GO
IF OBJECT_ID(N'[dbo].[Servises]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Servises];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Extracts'
CREATE TABLE [dbo].[Extracts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Servise] nchar(150)  NULL,
    [price] nchar(10)  NULL,
    [With_privilege] nchar(150)  NULL,
    [id_renter] int  NULL,
    [RenterId] int  NOT NULL
);
GO

-- Creating table 'Privileges'
CREATE TABLE [dbo].[Privileges] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nchar(150)  NULL,
    [Procent] float  NULL,
    [id_renter] int  NULL,
    [RenterId] int  NOT NULL
);
GO

-- Creating table 'Renters'
CREATE TABLE [dbo].[Renters] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [F_name] nchar(150)  NULL,
    [Name] nchar(150)  NULL,
    [L_name] nchar(150)  NULL,
    [Adres] nchar(150)  NULL,
    [Privileges] bit  NULL,
    [Debtor] bit  NULL
);
GO

-- Creating table 'Servises'
CREATE TABLE [dbo].[Servises] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nchar(150)  NULL,
    [Price] decimal(19,4)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Extracts'
ALTER TABLE [dbo].[Extracts]
ADD CONSTRAINT [PK_Extracts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Privileges'
ALTER TABLE [dbo].[Privileges]
ADD CONSTRAINT [PK_Privileges]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Renters'
ALTER TABLE [dbo].[Renters]
ADD CONSTRAINT [PK_Renters]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Servises'
ALTER TABLE [dbo].[Servises]
ADD CONSTRAINT [PK_Servises]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [RenterId] in table 'Privileges'
ALTER TABLE [dbo].[Privileges]
ADD CONSTRAINT [FK_RenterPrivilege]
    FOREIGN KEY ([RenterId])
    REFERENCES [dbo].[Renters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RenterPrivilege'
CREATE INDEX [IX_FK_RenterPrivilege]
ON [dbo].[Privileges]
    ([RenterId]);
GO

-- Creating foreign key on [RenterId] in table 'Extracts'
ALTER TABLE [dbo].[Extracts]
ADD CONSTRAINT [FK_RenterExtract]
    FOREIGN KEY ([RenterId])
    REFERENCES [dbo].[Renters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RenterExtract'
CREATE INDEX [IX_FK_RenterExtract]
ON [dbo].[Extracts]
    ([RenterId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------