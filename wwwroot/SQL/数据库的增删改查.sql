--//创建一个表 register
CREATE TABLE [dbo].register
(
[ID] INT NOT NULL,
[name] NVARCHAR(10) NOT NULL,
age tinyint not null,
enroll date,
[PASSWORD] NVARCHAR(12)  NOT NULL,
[INviter] NVARCHAR(4) NOT NULL,
)

--一下的列子将使用register这个表来举例！！！！！！！
--//增加表中列的数据
ALTER TABLE [register]
ADD  AGE INT NOT NULL
--//删除表中列的数据
ALTER TABLE [register]
DROP COLUMN PASSWORD
--///修改表中列的数据
ALTER TABLE [register]
ALTER COLUMN AGE NVARCHAR(10) NULL
--////删除表
DROP TABLE [register];

--数据库的备份还原
--先创建一个新表一起帮
CREATE DATABASE [18BANG];
--切换使用另一个数据库
USE [17bang]
--要删除数据库之前先备份这个数据库
BACKUP DATABASE [18BANG] TO DISK ='D:\\18BANG.BNK'
--删除这个数据库
DROP DATABASE [18BANG];
--还原数据库
RESTORE DATABASE[18BANG] FROM DISK='D:\\18BANG.BNK'

--行数据的增删改查---

--增加行数据
INSERT register([Name], Age) VALUES(N'陈元',23);

--查询得到表数据
SELECT * FROM register;
--其中，星号（*）代表所有列。运行上述SQL语句，返回的就是Student表的所有行所有列的内容

-- 只查出Name和Age两列的数据
SELECT [Name], Age FROM register

 --所以，我们还可以使用AS（可省略）给它指定一个名称：

SELECT Age+10 AS BigAge FROM register
SELECT Age+10 BigAge FROM register --省略掉AS


--改
--- 把register的Age列上所有值改为18
UPDATE register SET Age = 18;


--删，可以有两种方式删除表数据
--1-DELETE
--删除Student表的所有行
DELETE register;


--2-TRUNCATE
--注意有TABLE关键字
TRUNCATE TABLE register;

--TRUNCATE和DELETE有什么区别呢？

--    TRUNCATE只能删除整张表数据，而DELETE是可以跟条件的。加上条件的DELETE可以只删除特定行（后文详述）

------------------------------------------------------------------------
-- WHERE子句

--可以在SELECT、UPDATE和DELETE后面添加WHERE子句，以进行条件查询和精确更新/删除。 

 --比如，我们要查询所有年龄（Age）大于18岁的同学：

SELECT * FROM register WHERE Age > 18

--给所有入学时间（Enroll）在9月的同学成绩加上10分：

UPDATE register SET Age += 10 WHERE Enroll BETWEEN '2017/8/31' AND '2017/10/1'
 --或者：

UPDATE Student SET Age = Age + 18; -- Age列所有值都加上18 
UPDATE Student SET Score = Score + Age; -- Score列所有值都加上Age的值

 --删除Id大于3的同学：

DELETE Student WHERE Id > 3
---------------------------------------------------------

--exists 检查集合,如果结果集有值,返回真,否则，返回假。
----------------------------------------------------------------------
--添加外键约束
ALTER TABLE STUDENTS --修改表
ADD CONSTRAINT FK_TEACHER_ID--添加约束，指定约束名称，外键建议以fk开头，后跟表和列名
FOREIGN KEY (TEACHERID)--约束类型：外键，且外键列为teacherid
REFERENCES TEACHER(ID)--外键表为teacher，作为外键使用的列为teacher上的id
--在建表的时候，直接在列后面添加，为了方便演示，我们要创建一个major表：
CREATE TABLE major(
id int not null primary key ,
[name] nvarchar(30),
TaughtBy int constraint fk_teacher_id foreign key(TeacherId) references teacher(id)
)