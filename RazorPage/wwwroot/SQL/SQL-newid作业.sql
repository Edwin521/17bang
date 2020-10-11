DROP TABLE keyword;
-- 观察一起帮的“关键字”功能，新建Keyword表，要求带一个自增的主键Id，起始值为10，步长为5；并存入若干条数据
create table keyword
(
[id] int primary key identity(10,5),
[data] nvarchar(30) not null,
)

insert keyword ([data]) values (N'编程开发语言');
insert keyword ([data]) values (N'c#');
insert keyword ([data]) values (N'Java');
insert keyword ([data]) values (N'JavaScript');
insert keyword ([data]) values (N'职场');
insert keyword ([data]) values (N'HTML');
select *from keyword;
--给User表中添加一个GUID的Id列，并存入若干条数据
insert into 表名 (字段名) values (newid())
begin tran
create table user1(
id nvarchar(50)
)

INSERT [user1]( id) VALUES(NEWID())
rollback
--Problem表已有Id列，如何给该列加上IDENTITY属性？ 
---

CREATE TABLE USER2(
username NVARCHAR(20) ,
[password] NVARCHAR(20),
invitedby NVARCHAR(20) ,
id2 INT IDENTITY PRIMARY KEY,

)
SELECT *FROM USER2
DROP TABLE USER2
SET IDENTITY_INSERT USER2 On;


 INSERT INTO USER2(username,[password],invitedby,id2) SELECT [user](username,[password],invitedby,id2) FROM [user]
--drop column  id2;




UPDATE USER2 SET ID2 = id;

select * from problem;

