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
begin tran

INSERT [user]( id) VALUES(NEWID())
rollback
--Problem表已有Id列，如何给该列加上IDENTITY属性？ 
---再建立一个新列，把这个列加上identity属性，关闭identity，然后把原来的id列内容复制过来，再删除原来的id列，再把identity打开，改掉这个列的列名。

alter table problem
--DROP COLUMN [ID];
ADD  [id] int IDENTITY not null ;


select * from problem;