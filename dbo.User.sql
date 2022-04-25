CREATE TABLE [dbo].[User]
(
	[Id] INT IDENTITY (1,1) NOT NULL, 
    [User_Name] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(50) NULL
	 CONSTRAINT [PK_User] PRIMARY KEY ([Id])
)
