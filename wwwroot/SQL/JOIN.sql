   ---- 1 联表查出求助的标题和作者用户名
   SELECT*FROM [USER]
   SELECT*FROM problem
   SELECT P.title,U.[NAME] FROM problem P    
	JOIN
	[USER] U  
	           
	ON P.AuthorId=U.ID      
   -- 2 查找并删除从未发布过求助的用户

BEGIN TRAN
(
 SELECT * FROM  [USER] U
 LEFT JOIN
 problem P
  ON P.AuthorId = U.ID 
 WHERE P.title IS NULL)
 
   -- 3 用一句SELECT显示出用户和他的邀请人用户名
 SELECT*FROM [USER]
 SELECT *FROM [Profile]


 
   SELECT O.[NAME] 用户,I.[INVITEDBY] 邀请人  FROM [USER] O
   LEFT JOIN 
   [USER] I
   ON O.[ID]=I.INVITEDBY
   -- 4 -17bang的关键字有“一级”“二级”和其他“普通（三）级”的区别：
   --     1请在表Keyword中添加一个字段，记录这种关系

   SELECT *FROM Keyword
   ALTER TABLE Keyword
   ADD [upLever] int
   
   SELECT K3.KWORD 关键字,K2.KWORD 上一级,K1.KWORD 再上一级
   FROM Keyword K1
   RIGHT JOIN Keyword K2
      ON K1.ID=K2.[upLever]
	  RIGHT JOIN Keyword K3
   ON K2.ID=K3.[upLever]


  
   --     2然后用一个SELECT语句查出所有普通关键字的上一级、以及上上一级的关键字名称，比如：

   -- 1-17bang中除了求助（Problem），还有意见建议（Suggest）和文章（Article），他们都包含Title、Content、PublishTime和Auhthor四个字段，但是：
   --     建议和文章没有悬赏（Reward）
   --     建议多一个类型：Kind NVARCHAR(20)）
   --     文章多一个分类：Category INT）
   -- 2 请按上述描述建表。然后，用一个SQL语句显示某用户发表的求助、建议和文章的Title、Content，并按PublishTime降序排列
      SELECT*FROM [USER]

   CREATE TABLE Suggest(
   ID INT PRIMARY KEY IDENTITY(1,1),
   TITLE NVARCHAR(50),
   CONTENT NVARCHAR(200),
   PUBLISHTIME DATETIME ,
   AUTHORID INT CONSTRAINT FK_Suggest_AUTHORID FOREIGN KEY REFERENCES [USER](ID),
   Kind NVARCHAR(20)

   )
   INSERT Suggest VALUES(N'建议2',N'内容2','2020-4-8',4,N'种类2')
   INSERT Suggest VALUES(N'建议3',N'内容3','2020-5-8',6,N'种类3')
   INSERT Suggest VALUES(N'建议4',N'内容4','2020-6-8',11,N'种类4')

    CREATE TABLE Article(
   ID INT PRIMARY KEY IDENTITY(1,1),
   TITLE NVARCHAR(50),
   CONTENT NVARCHAR(200),
   PUBLISHTIME DATETIME ,
   AUTHORID INT CONSTRAINT FK_Article_AUTHORID FOREIGN KEY REFERENCES [USER](ID),
  Category INT,

   )


    INSERT Article VALUES(N'建议2',N'内容2','2020-4-8',4,1)
	 INSERT Article VALUES(N'建议3',N'内容3','2020-5-8',6,2)
   INSERT Article VALUES(N'建议4',N'内容4','2020-6-8',11,3)

   SELECT *FROM Suggest
   SELECT *FROM Article
   SELECT *FROM problem


   ALTER TABLE problem
   ALTER COLUMN  publishdatetime NVARCHAR(MAX)



   

   SELECT A.TITLE,A.CONTENT ,PUBLISHTIME FROM Article A     
   UNION 
   SELECT S.TITLE,S.CONTENT ,PUBLISHTIME FROM Suggest S   
    UNION 
   SELECT  P.title,P.content,PUBLISHTIME FROM    problem P  
   ORDER BY PUBLISHTIME DESC
    
   
 



   