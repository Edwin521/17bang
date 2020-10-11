-- 创建求助的应答表 TResponse(Id, Content, AuthorId, ProblemId, CreateTime)

CREATE TABLE TResponse(
ID INT PRIMARY KEY IDENTITY(1,1),
Content NVARCHAR(500),
AuthorId INT CONSTRAINT FK_TResponse_AuthorId FOREIGN KEY REFERENCES [USER](ID)  ,
ProblemId INT CONSTRAINT FK_TResponse_ProblemId FOREIGN KEY REFERENCES problem(id) ,
CreateTime DATETIME ,
)
SELECT *FROM TResponse
SELECT *FROM problem
SELECT *FROM [USER]


INSERT TResponse VALUES (N'内容1',3,2,'2020-8-8')
INSERT TResponse VALUES (N'内容2',4,3,'2020-12-8')
INSERT TResponse VALUES (N'内容3',6,5,'2020-12-12')
INSERT TResponse VALUES (N'内容4',1011,6,'2020-8-8')
--然后生成一个视图VResponse(ResponseId, Content, AuthorId, AuthorName, ProblemId, ProblemTitle, CreateTime)，要求该视图：
SELECT *FROM TResponse
GO


CREATE VIEW  VResponse (
ResponseId,Content,ResponseAuthorId,ResponseAuthorName,ProblemId,
ProblemAuthorName,ProblemTitle,CreateTime
)
 WITH ENCRYPTION ,SCHEMABINDING
 AS
 SELECT
 R.ID,
 R.Content,
 R.AuthorId,
 U2.[NAME],
 p.ID,
 u.[NAME],
 P.title,
 P.PUBLISHTIME
 FROM dbo.problem P
 JOIN dbo.TResponse R
 ON R.ProblemId=P.ID
 JOIN dbo.[USER] U
 ON P.AuthorId=U.ID
 JOIN dbo.[USER] U2
 ON R.AuthorId=U2.ID
 WHERE P.reward>5
 WITH CHECK OPTION
 -- 还可以添加其他的WHERE/GROUP/HAVING等子句

--    能展示应答作者的用户名、应答对应求助的标题和作者用户名
--    只显示求助悬赏值大于5的数据
--    已被加密
--    保证其使用的基表结构无法更改
GO
--演示：在VResponse中插入一条数据，却不能在视图中显示
INSERT VResponse(ResponseId, Content, ProblemId, CreateTime) 
VALUES(200,N'内容一',2,'20200-9-8')
--修改VResponse，让其能避免上述情形
--创建视图VProblemKeyword(ProblemId, ProblemTitle, ProblemReward, KeywordAmount)，要求该视图：
go

CREATE VIEW VProblemKeyword(
ProblemId, ProblemTitle, ProblemReward, KeywordAmount
)
AS SELECT 
P.title,
P.reward,
P.ID,
COUNT(*)
FROM 
dbo.KeywordToProblem r
JOIN dbo.problem p
ON R.ProblemId =P.ID
JOIN dbo.Keyword k
ON R.KeywordId=P.ID
GROUP BY P.ID,P.title,P.reward
GO

SELECT*FROM VProblemKeyword
--    能反映求助的标题、使用关键字数量和悬赏
--    在ProblemId上有一个唯一聚集索引
CREATE UNIQUE CLUSTERED INDEX IX_VProblemKeyword_ProblemId  ON VProblemKeyword(ProblemId)
--    在ProblemReward上有一个非聚集索引
CREATE INDEX IX_VProblemKeyword_ProblemReward ON VProblemKeyword(ProblemReward)
--在基表中插入/删除数据，观察VProblemKeyword是否相应的发生变化


