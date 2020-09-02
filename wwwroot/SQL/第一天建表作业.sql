CREATE TABLE [dbo].[EDWIN]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [InviterName] NCHAR(10) NULL, 
    [InviteCode] NCHAR(10) NULL, 
    [UserName] NCHAR(10) NULL, 
    [Password] NCHAR(10) NULL, 
    [ConfirmPassword] NCHAR(10) NULL, 
    [InputImageCode] NCHAR(10) NULL
)
