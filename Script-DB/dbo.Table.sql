CREATE TABLE [dbo].[Table]
(
	[Id]               INT           IDENTITY (1, 1) NOT NULL, 
    [nome] NVARCHAR(50) NOT NULL, 
    [sobrenome] NVARCHAR(50) NOT NULL, 
    [email] NVARCHAR(50) NOT NULL, 
    [data_aniversario] DATE NOT NULL
)
