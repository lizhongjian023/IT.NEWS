
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/08/2019 21:02:48
-- Generated from EDMX file: C:\Users\Administrator\OneDrive\C#学习项目\IT.NEWS\IT.NEWS.Model\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HT_News];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Company]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Company];
GO
IF OBJECT_ID(N'[dbo].[Department]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Department];
GO
IF OBJECT_ID(N'[dbo].[UserInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserInfo];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[News]', 'U') IS NOT NULL
    DROP TABLE [dbo].[News];
GO
IF OBJECT_ID(N'[dbo].[NewsComments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NewsComments];
GO
IF OBJECT_ID(N'[dbo].[UserMSG]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserMSG];
GO
IF OBJECT_ID(N'[dbo].[LogA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LogA];
GO
IF OBJECT_ID(N'[dbo].[Test]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Test];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Company'
CREATE TABLE [dbo].[Company] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CId] smallint  NULL,
    [CName] nvarchar(max)  NULL,
    [UserInfoId] nvarchar(max)  NULL
);
GO

-- Creating table 'Department'
CREATE TABLE [dbo].[Department] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DepartmentId] smallint  NULL,
    [DName] nvarchar(max)  NULL,
    [DcompanyIId] smallint  NULL,
    [UserInfoId] int  NULL
);
GO

-- Creating table 'UserInfo'
CREATE TABLE [dbo].[UserInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Age] smallint  NULL,
    [WorkCode] int  NULL,
    [Company] nvarchar(max)  NULL,
    [Department] nvarchar(max)  NULL,
    [CId] int  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] smallint  NULL,
    [LoginId] nvarchar(max)  NULL,
    [Password] nvarchar(max)  NULL,
    [Name] nvarchar(max)  NULL,
    [Address] nvarchar(max)  NULL,
    [Number] nvarchar(max)  NULL,
    [ll] nvarchar(max)  NULL
);
GO

-- Creating table 'News'
CREATE TABLE [dbo].[News] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(50)  NULL,
    [NewsMsg] nvarchar(max)  NULL,
    [SubTime] nvarchar(50)  NULL,
    [Author] nvarchar(50)  NULL,
    [ImagePath] nvarchar(50)  NULL
);
GO

-- Creating table 'NewsComments'
CREATE TABLE [dbo].[NewsComments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NewsId] nvarchar(50)  NULL,
    [Msg] nvarchar(max)  NULL,
    [CrDateTime] nvarchar(50)  NULL
);
GO

-- Creating table 'UserMSG'
CREATE TABLE [dbo].[UserMSG] (
    [userid] int IDENTITY(1,1) NOT NULL,
    [password] nvarchar(2000)  NULL,
    [zt] nvarchar(50)  NULL,
    [username] nvarchar(50)  NULL,
    [workcode] nvarchar(50)  NULL,
    [Email] nvarchar(50)  NULL,
    [phoneNumber] nvarchar(50)  NULL,
    [address] nvarchar(100)  NULL,
    [departmentid] nvarchar(50)  NULL,
    [company] nvarchar(50)  NULL,
    [login] nvarchar(50)  NULL
);
GO

-- Creating table 'LogA'
CREATE TABLE [dbo].[LogA] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [Thread] varchar(100)  NULL,
    [Level] varchar(100)  NULL,
    [Logger] varchar(200)  NULL,
    [Operator] int  NULL,
    [Message] varchar(max)  NULL,
    [ActionType] int  NULL,
    [Operand] varchar(300)  NULL,
    [IP] varchar(20)  NULL,
    [MachineName] varchar(100)  NULL,
    [Browser] varchar(50)  NULL,
    [Location] varchar(max)  NULL,
    [Exception] varchar(max)  NULL
);
GO

-- Creating table 'Test'
CREATE TABLE [dbo].[Test] (
    [ID] nvarchar(50)  NOT NULL,
    [Test1] nvarchar(50)  NULL,
    [Name] nvarchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Company'
ALTER TABLE [dbo].[Company]
ADD CONSTRAINT [PK_Company]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Department'
ALTER TABLE [dbo].[Department]
ADD CONSTRAINT [PK_Department]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserInfo'
ALTER TABLE [dbo].[UserInfo]
ADD CONSTRAINT [PK_UserInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'News'
ALTER TABLE [dbo].[News]
ADD CONSTRAINT [PK_News]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NewsComments'
ALTER TABLE [dbo].[NewsComments]
ADD CONSTRAINT [PK_NewsComments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [userid] in table 'UserMSG'
ALTER TABLE [dbo].[UserMSG]
ADD CONSTRAINT [PK_UserMSG]
    PRIMARY KEY CLUSTERED ([userid] ASC);
GO

-- Creating primary key on [ID], [Date] in table 'LogA'
ALTER TABLE [dbo].[LogA]
ADD CONSTRAINT [PK_LogA]
    PRIMARY KEY CLUSTERED ([ID], [Date] ASC);
GO

-- Creating primary key on [ID] in table 'Test'
ALTER TABLE [dbo].[Test]
ADD CONSTRAINT [PK_Test]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------