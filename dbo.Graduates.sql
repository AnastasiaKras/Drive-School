CREATE TABLE [dbo].[Graduates] (
    [Id]                INT           NOT NULL,
    [ФИО]               NVARCHAR (50) NOT NULL,
    [Телефон]           NVARCHAR (50) NOT NULL,
    [Дата_рождения]     NVARCHAR (50) NOT NULL,
    [Паспортные_данные] NVARCHAR (50) NOT NULL,
    [Место_жительства]  NVARCHAR (50) NOT NULL,
    [Дата_выпуска]      DATE  NOT NULL,
    CONSTRAINT [PK_Graduates] PRIMARY KEY CLUSTERED ([Id] ASC)
);

