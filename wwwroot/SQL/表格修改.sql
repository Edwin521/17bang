CREATE TABLE [dbo].[EDWIN] (
    [Id]              INT        NOT NULL,
    [InviterName]     NCHAR (10) NULL,
    [InviteCode]      INT NULL,
    [UserName]        NCHAR (10) NULL,
    [Password]        NCHAR (20) NULL,
    [ConfirmPassword] NCHAR (20) NULL,
    [InputImageCode]  NCHAR (4) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

