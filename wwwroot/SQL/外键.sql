


    --使用SELECT INTO，以TProblem中的数据为基础，新建一个Author和Reward都没有NULL值的新表：TNewProblem表
 SELECT*
 INTO TNEWPROBLEM
 FROM problem WHERE Author IS NOT NULL AND reward IS NOT NULL;

 SELECT*FROM TNEWPROBLEM
  SELECT*FROM problem
  SELECT*FROM TProblemStatus
 
    --使用INSERT SELECT, 将TProblem中Reward为NULL的行再次插入到TProblem中
    INSERT TNEWPROBLEM
    SELECT *FROM problem WHERE reward IS NULL

    --使用OVER，统计出每个Author悬赏值的平均值、最大值和最小值，去除重复数据，然后用新表TProblemStatus存放
 SELECT DISTINCT Author,
 AVG(reward) OVER(PARTITION BY Author) N'平均值',
 MAX(reward) OVER(PARTITION BY Author) N'最大值',
 MIN(reward) OVER(PARTITION BY Author) N'最小值'
 INTO TProblemStatus
    FROM problem
    
    SELECT *FROM TProblemStatus
   
  
    --使用CASE...WHEN，颠倒TProblem中的NeedRemote
    --UPDATE problem SET needremotehelp 
    SELECT id,title,
    CASE needremotehelp  
    WHEN 1 THEN 0
          ELSE 1
    END as N'修改过后的值'
    FROM problem 
    --使用CASE...WHEN，用一条SQL语句，完成SQL入门-7：函数中第4题第3小题
    --在表TProblem中,有一些标题以test、[test]后者Test-开头的求助，找到他们并把这些前缀都换成大写
    SELECT*FROM problem
    begin tran
    UPDATE problem SET title=
    CASE 
    WHEN title LIKE N'test%' THEN  N'TEST%'
    WHEN title LIKE N'[test]%' THEN  N'TEST%'
    WHEN title LIKE N'Test%' THEN  N'TEST%'
    end 





------------------------






--外键------观察并模拟17bang项目中的：)


--   用户资料，新建用户资料（Profile）表，和User形成1:1关联（有无约束？）。用SQL语句演示：

select *from [User]
select * from [Profile]


create table [Profile](


id int primary key identity,
username nvarchar(30),
)
drop table [USER2] 



insert [Profile] values(N'廖光银'); 
insert [Profile] values(N'阿泰'); 
insert [Profile] values(N'刘伟'); 
insert [Profile] values(N'周丁浩'); 
insert [Profile] values(N'李智博'); 


CREATE TABLE [USER](
ID INT NOT NULL IDENTITY PRIMARY KEY,
[NAME] NVARCHAR(30),
[PASSWORD] NVARCHAR(30),
[DESCRIPTION] NVARCHAR(100),
INVITEDBY INT NOT NULL ,
)
insert [user] values(N'廖光银',1234,N'描述',NULL); 
insert [user] values(N'阿泰' ,4456,N'描述',NULL); 
insert [user] values(N'刘伟' ,1245,N'描述',NULL); 
insert [user] values(N'周丁浩',56421,N'描述',NULL); 
insert [user] values(N'李智博',53411,N'描述',NULL); 

--添加外键约束
ALTER TABLE [USER]
ADD CONSTRAINT FK_invitedby_id
FOREIGN KEY (invitedby)
REFERENCES [profile](id)


--1对1要 添加唯一约束
ALTER TABLE [USER]
ADD CONSTRAINT UQ_USER_invitedby UNIQUE(invitedby);
--   新建一个填写了用户资料的注册用户
insert [user] values(N'李智博',53411,N'描述',6); 

select *from [User]
select * from [Profile]
--   通过Id查找获得某注册用户及其用户资料
SELECT *FROM  [USER] WHERE ID=11;
--   删除某个Id的注册用户
BEGIN TRAN
DELETE  [USER] WHERE ID=3
ROLLBACK
--   帮帮点说明：新建Credit表，可以记录用户的每一次积分获得过程，即：某个用户，在某个时间，因为某某原因，获得若干积分
CREATE TABLE CREDIT(
ID INT IDENTITY,
[USERNAME] NVARCHAR(30),
[TIME] DATETIME ,
[reason] NVARCHAR(200),
NUM INT ,
)
SELECT *FROM CREDIT

--   发布求助，在Problem和User之间建立1:n关联（含约束）。用SQL语句演示：
CREATE TABLE [dbo].[problem] (
    [title]           NVARCHAR (200) NULL,
    [content]         NTEXT          NULL,
    [needremotehelp]  BIT            NULL,
    [reward]          INT            NULL,
    [publishdatetime] DATETIME       NULL,
    [Author]          NVARCHAR (30)  NULL,
    [ID]              INT            NULL
);
SELECT *FROM problem
SELECT *FROM [USER]

--   某用户发布一篇求助，

--   将该求助的作者改成另外一个用户

--   删除该用户

--   求助列表：新建Keyword表，和Problem形成n:n关联（含约束）。用SQL语句演示：
SELECT *FROM Keyword 
SELECT *FROM problem


CREATE TABLE Keyword(
ID INT NOT NULL,


)

--   查询获得：某求助使用了多少关键字，某关键字被多少求助使用

--   \发布了一个使用了若干个关键字的求助

--   该求助不再使用某个关键字

--   删除该求助

--   删除某关键字

