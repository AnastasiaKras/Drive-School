CREATE TABLE [dbo].[Teacher] (
    [Id]                     INT           IDENTITY (1, 1) NOT NULL,
    [ФИО]                    NVARCHAR (50) NOT NULL,
    [Дата рождения]          NVARCHAR (50) NOT NULL,
    [Место жительства]       NVARCHAR (50) NOT NULL,
    [Паспортные данные ]     NVARCHAR (50) NOT NULL,
    [Телефон]                NVARCHAR (50) NOT NULL,
    [Категория преподавания] NVARCHAR (50) NOT NULL,
    [Категория]              NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED ([Id] ASC)
);

