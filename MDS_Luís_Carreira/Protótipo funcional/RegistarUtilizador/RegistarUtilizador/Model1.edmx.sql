
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/31/2016 12:16:03
-- Generated from EDMX file: C:\Users\Luis Carreira\Documents\ESTG\TeSP - 1º ano\2º Semestre\MDS\Trabalho_prático\2ª ent\Protótipo funcional\RegistarUtilizador\RegistarUtilizador\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RegistarUtilizadorBD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UtilizadorASet'
CREATE TABLE [dbo].[UtilizadorASet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Apelido] nvarchar(max)  NOT NULL,
    [Sexo] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [CodP] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [DataNasc] nvarchar(max)  NOT NULL,
    [CC] nvarchar(max)  NOT NULL,
    [EstadoC] nvarchar(max)  NOT NULL,
    [Perfil] nvarchar(max)  NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UtilizadorASet'
ALTER TABLE [dbo].[UtilizadorASet]
ADD CONSTRAINT [PK_UtilizadorASet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------