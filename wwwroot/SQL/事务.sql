--用户（Reigister）发布一篇悬赏币若干的求助（Problem），他的帮帮币（BMoney）也会相应减少，但他的帮帮币总额不能少于0分：请综合使用TRY...CATCH和事务完成上述需求。

CREATE TABLE BangMoney(
[Name] NVARCHAR(20) ,

Balance int
)
SELECT *FROM BangMoney

INSERT BangMoney VALUES(N'李强',100)
INSERT BangMoney VALUES(N'王超',100)
INSERT BangMoney VALUES(N'赵云',100)

UPDATE BangMoney SET Balance-=1000 WHERE [NAME]=N'李强';
UPDATE BangMoney SET Balance+=1000 WHERE [NAME]=N'王超';

ALTER TABLE BangMoney
ADD CONSTRAINT CK_BangMoney_Balance CHECK (Balance>=0)

GO

SELECT *FROM [USER]
SELECT*FROM [problem]
ALTER TABLE [USER]
ADD BangMoney INT CONSTRAINT CK_USER_BangMoney CHECK(BangMoney>=0)
UPDATE [USER]  SET BangMoney =20
BEGIN TRY
	BEGIN TRAN
	INSERT problem VALUES(N'新发布的标题',N'新的内容',1,30,'2020-10-1',11,3)
	UPDATE [USER] SET BangMoney-=15 WHERE ID=3
	COMMIT
END TRY 
BEGIN CATCH
	ROLLBACK
END CATCH

