
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/31/2016 18:56:26
-- Generated from EDMX file: c:\users\miguel\documents\visual studio 2013\Projects\Prototipo\Prototipo\BaseDeDadosPrototipo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BaseDeDadosPrototipo];
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

-- Creating table 'ConsultasSet'
CREATE TABLE [dbo].[ConsultasSet] (
    [IdConsulta] int IDENTITY(1,1) NOT NULL,
    [DataDeRealizacao] datetime  NOT NULL,
    [DoutorResponsavel] nvarchar(max)  NOT NULL,
    [Exames] nvarchar(max)  NOT NULL,
    [PacientesIdPaciente] int  NOT NULL
);
GO

-- Creating table 'MedicacaoSet'
CREATE TABLE [dbo].[MedicacaoSet] (
    [IdMedicacao] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Quantidade] int  NOT NULL,
    [ConsultasIdConsulta] int  NOT NULL
);
GO

-- Creating table 'PacientesSet'
CREATE TABLE [dbo].[PacientesSet] (
    [IdPaciente] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [BI_CC] int  NOT NULL,
    [DataNascimento] datetime  NOT NULL,
    [NºSNS] int  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Contacto] nvarchar(max)  NOT NULL,
    [NIF] int  NOT NULL,
    [Sexo] nvarchar(max)  NOT NULL,
    [EstadoCivil] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdConsulta] in table 'ConsultasSet'
ALTER TABLE [dbo].[ConsultasSet]
ADD CONSTRAINT [PK_ConsultasSet]
    PRIMARY KEY CLUSTERED ([IdConsulta] ASC);
GO

-- Creating primary key on [IdMedicacao] in table 'MedicacaoSet'
ALTER TABLE [dbo].[MedicacaoSet]
ADD CONSTRAINT [PK_MedicacaoSet]
    PRIMARY KEY CLUSTERED ([IdMedicacao] ASC);
GO

-- Creating primary key on [IdPaciente] in table 'PacientesSet'
ALTER TABLE [dbo].[PacientesSet]
ADD CONSTRAINT [PK_PacientesSet]
    PRIMARY KEY CLUSTERED ([IdPaciente] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ConsultasIdConsulta] in table 'MedicacaoSet'
ALTER TABLE [dbo].[MedicacaoSet]
ADD CONSTRAINT [FK_ConsultasMedicacao]
    FOREIGN KEY ([ConsultasIdConsulta])
    REFERENCES [dbo].[ConsultasSet]
        ([IdConsulta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultasMedicacao'
CREATE INDEX [IX_FK_ConsultasMedicacao]
ON [dbo].[MedicacaoSet]
    ([ConsultasIdConsulta]);
GO

-- Creating foreign key on [PacientesIdPaciente] in table 'ConsultasSet'
ALTER TABLE [dbo].[ConsultasSet]
ADD CONSTRAINT [FK_PacientesConsultas]
    FOREIGN KEY ([PacientesIdPaciente])
    REFERENCES [dbo].[PacientesSet]
        ([IdPaciente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PacientesConsultas'
CREATE INDEX [IX_FK_PacientesConsultas]
ON [dbo].[ConsultasSet]
    ([PacientesIdPaciente]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------