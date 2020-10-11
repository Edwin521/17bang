DECLARE @NUM INT=1

WHILE (@NUM<=4)
BEGIN 
		PRINT SPACE(4-@NUM)+REPLICATE(@NUM*2-1,@NUM*2-1)
		SET @NUM+=1
	
END
 ----

 DECLARE @NUM INT =1
 WHILE (@NUM<=4)
 BEGIN 
		PRINT SPACE(4-@NUM)+REPLICATE(@NUM*2-1,@NUM*2-1)
		SET @NUM+=1
 END



--TProblem中：

--    找出所有周末发布的求助（添加CreateTime列，如果还没有的话）

SELECT *FROM TNEWPROBLEM WHERE DATEPART(WEEKDAY,publishdatetime) BETWEEN 6 AND 7

--    找出每个作者所有求助悬赏的平均值，精确到小数点后两位

SELECT ROUND(AVG(reward),2),Author FROM TNEWPROBLEM    
GROUP BY Author
--    有一些标题以test、[test]后者Test-开头的求助，找打他们并把这些前缀都换成大写

UPDATE TNEWPROBLEM SET title =UPPER(N'test')+SUBSTRING(title,LEN(N'test')+1,20)
 WHERE TITLE LIKE N'test%'


PRINT UPPER(N'[test]') 

 UPDATE TNEWPROBLEM SET title=UPPER(N'[test]')+SUBSTRING(title,LEN(N'[test]')+1,20)
 WHERE title LIKE N'[test]%'

 UPDATE TNEWPROBLEM SET title=UPPER(N'Test')+SUBSTRING(title,LEN(N'Test')+1,20)
 WHERE title LIKE N'Test%'

 SELECT *FROM TNEWPROBLEM

SELECT REPLACE(title,N'test',N'TEST')FROM TNEWPROBLEM

GO
-----------定义一个函数GetBigger(INT a, INT b)，可以取a和b之间的更大的一个值
CREATE FUNCTION GetBigger( @A INT,@B INT )    -- 创建函数YzAdd,该函数有两个INT类型的参数@a和@b
RETURNS INT                              -- 函数返回的类型也是INT
AS                                       
BEGIN                                    
	if @A>@B RETURN @A
	ELSE if @A<@B   RETURN @B
	ELSE  RETURN 0	
	        
END


--创建一个单行表值函数GetLatestPublish(INT n)，返回最近发布的n篇求助
GO
CREATE FUNCTION GetLatestPublish(@N INT)
RETURNS TABLE
RETURN SELECT TOP(@N)  * FROM problem
ORDER BY PUBLISHTIME DESC
GO
SELECT *FROM  GetLatestPublish(3)

---创建一个多行表值函数GetByReward(INT n, BIT asc)，如果asc为1，返回悬赏最少的n位同学；否则，返回悬赏最多的n位同学。

GO
CREATE FUNCTION GetByReward(@N INT,@asc BIT)
RETURNS @T TABLE([NAME] NVARCHAR(20),reward INT)
BEGIN 
	IF @asc=1 
	INSERT @T SELECT TOP(@N) AuthorId,reward FROM problem ORDER BY reward 
	ELSE
	INSERT @T SELECT TOP (@N) AuthorId,reward FROM problem ORDER BY reward DESC
	RETURN
END

GO
SELECT*FROM GetByReward(1,1)

SELECT *FROM problem