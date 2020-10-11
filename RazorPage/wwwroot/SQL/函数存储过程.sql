 --编写存储过程“一起帮用户注册”，包含以下逻辑：

 

 --   检查用户名是否重复。如果重复，返回错误代码：1
 CREATE PROCEDURE usp_register
 @OutCode int OUTPUT,
 @Username nvarchar(30),
 @Password nvarchar(30),
 @inviterId int  ,
 @inviteCode varchar(10)
  
 AS
 SET NOCOUNT ON
 SET @OutCode=0;
     







 --   检查用户名密码是否符合“长度不小于4位”的要求。如果不符合，返回错误代码：2

 GO
 create procedure usp_register
 @username nvarchar(30),
 @password nvarchar(30),
 @inviter nvarchar(30),
 @inviteCode varchar(10),
 @outCode int output
 AS
 SET NOCOUNT ON
 SET @outCode=0


 IF  EXISTS (SELECT*FROM [USER] WHERE [NAME]=@USERNAME)
 BEGIN 
 SET @outCode=1;
 END
 ELSE IF LEN(@USERNAME)<4 OR LEN(@PASSWORD)<4
 BEGIN
 SET @outCode=2
 END
 ELSE IF @INVITECODE<>(SELECT INVITECODE FROM [USER] WHERE [NAME]=INVITER)
 SET @outCode =11
 ELSE IF @INVITER NOT IN (SELECT [NAME] FROM [USER] )
 SET @outCode=10




 ------GO


 IF LEN(@Username )<4 OR LEN(@Password) <4
 BEGIN 
		SET @OutCode =2

 END
 ELSE IF EXISTS(SELECT*FROM [USER] WHERE [NAME]=@Username)
 BEGIN
		SET @OutCode=1
END
ELSE  IF @inviterId NOT IN(SELECT [id] FROM [USER] )
BEGIN 
	--DECLARE @Code TABLE(ID INT ,Code NVARCHAR(20))=
	--(SELECT ID ,[CODE] FROM [USER]  WHERE [NAME]=@Code )
	--IF @Code IS NULL 
	SET @OutCode = 10
END
ELSE IF @inviteCode<>(SELECT inviteCode FROM [USER] WHERE ID =@inviterID)
BEGIN 
	SET @OutCode =11
END

IF @OutCode=0
INSERT [USER]([NAME],[PASSWORD],INVITEDBY) VALUES(@Username,@Password,@inviter)

SET NOCOUNT OFF

 --   如果有邀请人：
 --       检查邀请人是否存在，如果不存在，返回错误代码：10
 --       检查邀请码是否正确，如果邀请码不正确，返回错误代码：11
 --   将用户名、密码和邀请人存入数据库（TRegister）

 --   给邀请人增加10个帮帮点积分
 BEGIN TRAN
 INSERT BangMoney VALUES(@inviter,@BALANCE+10)
 --UPDATE [BangMoney] SET [BALANCE]+=10 WHERE [Name]=@inviter

 --   通知邀请人（TMessage中生成一条数据）某人使用了他作为邀请人。
 INSERT [TMessage] VALUES (@Username+N'使用了'+@inviter+N'作为邀请人')

  ---
  DECLARE @Code int
  EXECUTE usp_register
    @OutCode OUTPUT ,
	 @Username =N'EDWIN',
	 @Password =N'1234',
	 @inviter =N'ZYF',
	 @inviteCode=N'3333'






 --------------
--确保Problem有“发布时间（PublishTime）”和“最后更新时间（LatestUpdateTime）”两列，创建触发器实现：

    --更新一条数据，自动将当前时间计入该行数据的LatestUpdateTime插入一条数据，自动将当前时间计入该行数据的PublishTime（提示：INSERTED伪表）

	SELECT*FROM problem
	SELECT @@IDENTITY FROM problem








	ALTER TABLE problem
	ADD LatestUpdateTime DATETIME 
	GO



	CREATE TRIGGER  CreateTime
	ON problem
	FOR INSERT 
	AS
	UPDATE problem SET PUBLISHTIME=GETDATE() WHERE ID=@@IDENTITY;
	UPDATE problem SET LatestUpdateTime=GETDATE() WHERE ID=@@IDENTITY







	INSERT problem VALUES (N'新插入的title',N'内容2',1,78,12,'2020-9-9',3)
	go

	CREATE TRIGGER UpdateTime ON PROBLEM
	FOR UPDATE
	AS
	UPDATE PROBLEM SET  LatestUpdateTime=GETDATE()FROM PROBLEM P 
	JOIN INSRTED I
	ON P.ID=I.ID


