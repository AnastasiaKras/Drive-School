CREATE TABLE [dbo].[lessons] (
    [Id]                                    INT           IDENTITY (1, 1) NOT NULL,
    [Категория]                             NVARCHAR (50) NOT NULL,
    [Группа]                                INT           NOT NULL,
    [ФИО]                                   NVARCHAR (50) NOT NULL,
    [Инструктор]                            NVARCHAR (50) NOT NULL,
    [Количество часов вождения]             NVARCHAR (50) NULL,
    [Итоговая сумма за занятия по вождению] NVARCHAR (50) NULL,
    CONSTRAINT [PK_lesson] PRIMARY KEY CLUSTERED ([Id] ASC)
);

