CREATE TABLE [dbo].[lessons]
(
	[Id] INT NOT NULL  IDENTITY (1, 1) NOT NULL,
	 [Категория]      NVARCHAR (50) NOT NULL,
    [Группа]         INT           NOT NULL,
	 [ФИО]                   NVARCHAR (50) NOT NULL,
	[Инструктор]  NVARCHAR (50) NOT NULL
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED ([Id] ASC)
)
