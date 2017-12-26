
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/29/2017 20:10:29
-- Generated from EDMX file: C:\Users\mstfm\Documents\Visual Studio 2017\Projects\LibraryApplication\LibraryApplication\ModelDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [LibraryApplication];
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

-- Creating table 'KitapSet'
CREATE TABLE [dbo].[KitapSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [KitapAdi] nvarchar(max)  NOT NULL,
    [SayfaSayisi] int  NOT NULL,
    [TasnifNo] nvarchar(max)  NOT NULL,
    [EklenmeTarihi] datetime  NOT NULL,
    [KiralikDurumu] bit  NULL,
    [YazarId] int  NOT NULL,
    [KategoriId] int  NOT NULL,
    [YayinEviId] int  NOT NULL,
    [KullaniciId] int  NOT NULL,
    [KiralanmaTarihi] datetime  NULL,
    [İadeTarihi] datetime  NULL,
    [Yazar_Id] int  NOT NULL,
    [Kategori_Id] int  NOT NULL,
    [YayinEvi_Id] int  NOT NULL,
    [OkunanKitap_Id] int  NOT NULL
);
GO

-- Creating table 'YazarSet'
CREATE TABLE [dbo].[YazarSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [YazarAdi] nvarchar(max)  NOT NULL,
    [YazarSoyadi] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'YayinEviSet'
CREATE TABLE [dbo].[YayinEviSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [YayinEviAdi] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'KategoriSet'
CREATE TABLE [dbo].[KategoriSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [KategoriAdi] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'KullaniciSet'
CREATE TABLE [dbo].[KullaniciSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Adi] nvarchar(max)  NOT NULL,
    [Soyadi] nvarchar(max)  NOT NULL,
    [Unvan] nvarchar(max)  NOT NULL,
    [DogumTarihi] datetime  NOT NULL,
    [KullaniciAdi] nvarchar(max)  NOT NULL,
    [Sifre] nvarchar(max)  NOT NULL,
    [Telefon] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL,
    [Adres] nvarchar(max)  NOT NULL,
    [CezaDurumu] bit  NOT NULL,
    [CezaSayisi] int  NOT NULL,
    [CezaBitisTarihi] datetime  NULL,
    [TCKimlikNo] nvarchar(11)  NOT NULL
);
GO

-- Creating table 'AdminSet'
CREATE TABLE [dbo].[AdminSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Adi] nvarchar(max)  NOT NULL,
    [Soyadi] nvarchar(max)  NOT NULL,
    [Unvan] nvarchar(max)  NOT NULL,
    [DogumTarihi] datetime  NOT NULL,
    [KullaniciAdi] nvarchar(max)  NOT NULL,
    [Sifre] nvarchar(max)  NOT NULL,
    [Telefon] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL,
    [Adres] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OkunanKitaplar'
CREATE TABLE [dbo].[OkunanKitaplar] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AlısTarih] datetime  NOT NULL,
    [TeslimTarihi] datetime  NOT NULL,
    [Kullanici_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'KitapSet'
ALTER TABLE [dbo].[KitapSet]
ADD CONSTRAINT [PK_KitapSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'YazarSet'
ALTER TABLE [dbo].[YazarSet]
ADD CONSTRAINT [PK_YazarSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'YayinEviSet'
ALTER TABLE [dbo].[YayinEviSet]
ADD CONSTRAINT [PK_YayinEviSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'KategoriSet'
ALTER TABLE [dbo].[KategoriSet]
ADD CONSTRAINT [PK_KategoriSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'KullaniciSet'
ALTER TABLE [dbo].[KullaniciSet]
ADD CONSTRAINT [PK_KullaniciSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AdminSet'
ALTER TABLE [dbo].[AdminSet]
ADD CONSTRAINT [PK_AdminSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OkunanKitaplar'
ALTER TABLE [dbo].[OkunanKitaplar]
ADD CONSTRAINT [PK_OkunanKitaplar]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Yazar_Id] in table 'KitapSet'
ALTER TABLE [dbo].[KitapSet]
ADD CONSTRAINT [FK_KitapYazar]
    FOREIGN KEY ([Yazar_Id])
    REFERENCES [dbo].[YazarSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KitapYazar'
CREATE INDEX [IX_FK_KitapYazar]
ON [dbo].[KitapSet]
    ([Yazar_Id]);
GO

-- Creating foreign key on [Kategori_Id] in table 'KitapSet'
ALTER TABLE [dbo].[KitapSet]
ADD CONSTRAINT [FK_KitapKategori]
    FOREIGN KEY ([Kategori_Id])
    REFERENCES [dbo].[KategoriSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KitapKategori'
CREATE INDEX [IX_FK_KitapKategori]
ON [dbo].[KitapSet]
    ([Kategori_Id]);
GO

-- Creating foreign key on [YayinEvi_Id] in table 'KitapSet'
ALTER TABLE [dbo].[KitapSet]
ADD CONSTRAINT [FK_KitapYayinEvi]
    FOREIGN KEY ([YayinEvi_Id])
    REFERENCES [dbo].[YayinEviSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KitapYayinEvi'
CREATE INDEX [IX_FK_KitapYayinEvi]
ON [dbo].[KitapSet]
    ([YayinEvi_Id]);
GO

-- Creating foreign key on [OkunanKitap_Id] in table 'KitapSet'
ALTER TABLE [dbo].[KitapSet]
ADD CONSTRAINT [FK_KitapOkunanKitap]
    FOREIGN KEY ([OkunanKitap_Id])
    REFERENCES [dbo].[OkunanKitaplar]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KitapOkunanKitap'
CREATE INDEX [IX_FK_KitapOkunanKitap]
ON [dbo].[KitapSet]
    ([OkunanKitap_Id]);
GO

-- Creating foreign key on [Kullanici_Id] in table 'OkunanKitaplar'
ALTER TABLE [dbo].[OkunanKitaplar]
ADD CONSTRAINT [FK_OkunanKitapKullanici]
    FOREIGN KEY ([Kullanici_Id])
    REFERENCES [dbo].[KullaniciSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OkunanKitapKullanici'
CREATE INDEX [IX_FK_OkunanKitapKullanici]
ON [dbo].[OkunanKitaplar]
    ([Kullanici_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------