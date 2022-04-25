CREATE TABLE [dbo].[Groups] (
    [Категория]      NVARCHAR (50) NULL,
    [Группа]         INT IDENTITY (1,1) NOT NULL,
    [Сроки_обучения] NVARCHAR (50) NULL,
    [Преподаватель]  NVARCHAR (50) NULL, 
    CONSTRAINT [PK_Groups] PRIMARY KEY ([Группа])
);