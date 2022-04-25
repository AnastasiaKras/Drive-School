CREATE TABLE [dbo].[Students] (
    [Id]                    NVARCHAR (50) NOT NULL,
    [ФИО]                   NVARCHAR (50) NOT NULL,
    [Дата_рождения]         NVARCHAR (50) NOT NULL,
    [Телефон]               NVARCHAR (50) NOT NULL,
    [Место_жительства]      NVARCHAR (50) NOT NULL,
    [Паспортные_данные]     NVARCHAR (50) NOT NULL,
    [Сумма_оплаты]          NVARCHAR (50) NULL,
    [Сумма_задолженности]   NVARCHAR (50) NULL,
    [Серия_и_номер_справки] NVARCHAR (50) NOT NULL,
    [Дата_выдачи]           NVARCHAR (50) NOT NULL,
    [Кем_выдан]             NVARCHAR (50) NOT NULL,
    [Дата_выпуска]          NCHAR (10)    NULL,
    CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED ([Id] ASC)
);

