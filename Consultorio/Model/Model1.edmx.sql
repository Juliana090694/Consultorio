
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/03/2017 01:14:47
-- Generated from EDMX file: C:\Users\jujub\OneDrive\Documentos\Visual Studio 2015\Projects\Consultorio\Consultorio\Model\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Consultorío];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MedicoConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultaSet] DROP CONSTRAINT [FK_MedicoConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_PacienteConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultaSet] DROP CONSTRAINT [FK_PacienteConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_PacienteProntuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProntuarioSet] DROP CONSTRAINT [FK_PacienteProntuario];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultaProntuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProntuarioSet] DROP CONSTRAINT [FK_ConsultaProntuario];
GO
IF OBJECT_ID(N'[dbo].[FK_MedicoProntuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProntuarioSet] DROP CONSTRAINT [FK_MedicoProntuario];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PacienteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PacienteSet];
GO
IF OBJECT_ID(N'[dbo].[MedicoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MedicoSet];
GO
IF OBJECT_ID(N'[dbo].[ConsultaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConsultaSet];
GO
IF OBJECT_ID(N'[dbo].[ProntuarioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProntuarioSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PacienteSet'
CREATE TABLE [dbo].[PacienteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Carteirinha] nvarchar(max)  NOT NULL,
    [Idade] int  NOT NULL,
    [RG] nvarchar(max)  NOT NULL,
    [CPF] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MedicoSet'
CREATE TABLE [dbo].[MedicoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [CRM] nvarchar(max)  NOT NULL,
    [Idade] int  NOT NULL,
    [Especializacao] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [RG] nvarchar(max)  NOT NULL,
    [CPF] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ConsultaSet'
CREATE TABLE [dbo].[ConsultaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DataConsulta] datetime  NOT NULL,
    [Motivo] nvarchar(max)  NOT NULL,
    [Medico_Id] int  NOT NULL,
    [Paciente_Id] int  NOT NULL
);
GO

-- Creating table 'ProntuarioSet'
CREATE TABLE [dbo].[ProntuarioSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DescricaoPaciente] nvarchar(max)  NOT NULL,
    [Diagnostico] nvarchar(max)  NOT NULL,
    [PrescricaoMedicamento] nvarchar(max)  NOT NULL,
    [PrescricaoTratamento] nvarchar(max)  NOT NULL,
    [Paciente_Id] int  NOT NULL,
    [Consulta_Id] int  NOT NULL,
    [Medico_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PacienteSet'
ALTER TABLE [dbo].[PacienteSet]
ADD CONSTRAINT [PK_PacienteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MedicoSet'
ALTER TABLE [dbo].[MedicoSet]
ADD CONSTRAINT [PK_MedicoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ConsultaSet'
ALTER TABLE [dbo].[ConsultaSet]
ADD CONSTRAINT [PK_ConsultaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProntuarioSet'
ALTER TABLE [dbo].[ProntuarioSet]
ADD CONSTRAINT [PK_ProntuarioSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Medico_Id] in table 'ConsultaSet'
ALTER TABLE [dbo].[ConsultaSet]
ADD CONSTRAINT [FK_MedicoConsulta]
    FOREIGN KEY ([Medico_Id])
    REFERENCES [dbo].[MedicoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoConsulta'
CREATE INDEX [IX_FK_MedicoConsulta]
ON [dbo].[ConsultaSet]
    ([Medico_Id]);
GO

-- Creating foreign key on [Paciente_Id] in table 'ConsultaSet'
ALTER TABLE [dbo].[ConsultaSet]
ADD CONSTRAINT [FK_PacienteConsulta]
    FOREIGN KEY ([Paciente_Id])
    REFERENCES [dbo].[PacienteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteConsulta'
CREATE INDEX [IX_FK_PacienteConsulta]
ON [dbo].[ConsultaSet]
    ([Paciente_Id]);
GO

-- Creating foreign key on [Paciente_Id] in table 'ProntuarioSet'
ALTER TABLE [dbo].[ProntuarioSet]
ADD CONSTRAINT [FK_PacienteProntuario]
    FOREIGN KEY ([Paciente_Id])
    REFERENCES [dbo].[PacienteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteProntuario'
CREATE INDEX [IX_FK_PacienteProntuario]
ON [dbo].[ProntuarioSet]
    ([Paciente_Id]);
GO

-- Creating foreign key on [Consulta_Id] in table 'ProntuarioSet'
ALTER TABLE [dbo].[ProntuarioSet]
ADD CONSTRAINT [FK_ConsultaProntuario]
    FOREIGN KEY ([Consulta_Id])
    REFERENCES [dbo].[ConsultaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultaProntuario'
CREATE INDEX [IX_FK_ConsultaProntuario]
ON [dbo].[ProntuarioSet]
    ([Consulta_Id]);
GO

-- Creating foreign key on [Medico_Id] in table 'ProntuarioSet'
ALTER TABLE [dbo].[ProntuarioSet]
ADD CONSTRAINT [FK_MedicoProntuario]
    FOREIGN KEY ([Medico_Id])
    REFERENCES [dbo].[MedicoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoProntuario'
CREATE INDEX [IX_FK_MedicoProntuario]
ON [dbo].[ProntuarioSet]
    ([Medico_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------