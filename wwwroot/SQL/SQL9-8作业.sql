-- 在User表中：

--   
   

--



create table [user]
(
id int not null,
username nvarchar(20) not null,
[password] nvarchar(20) ,
invitedby nvarchar(10),
)

INSERT [user](username, [password]) VALUES(N'我爱17bang',5689);
 --查找没有录入密码的用户
SELECT username from [user] where [password]is null; 
 --删除用户名（UserName）中包含“管理员”或者“17bang”字样的用户
begin tran
delete [user] where username like N'%管理员%' or username like N'%17bang%' 
rollback



--------------------------------------------
--在Problem表中：

--    
--   
--    
--    
--给所有悬赏（Reward）大于10的求助标题加前缀：【推荐】
update problem set title=N'【推荐】'+title where reward >10;
-- 给所有悬赏大于20且发布时间（Created）在2019年10月10日之后的求助标题加前缀：【加急】
update problem set title=N'【加急】'+title where publishdatetime >2019/10/10 and reward>20;
--删除所有标题以中括号【】开头（无论其中有什么内容）的求助
begin tran
delete problem where title like N'【%】%';
rollback
--查找Title中第5个起，字符不为“数据库”且包含了百分号（%）的求助
select needremotehelp from problem where title not like N'____数据库%'and title like '%#%%' escape'#';



select * from problem;


----------------------------------
在Keyword表中：

--   
--   
-- 

create table keyword
(
[id] int primary key identity ,
[name] nvarchar(30),
[used] int,
)
 --找出所有被使用次数（Used）大于10小于50的关键字名称（Name）
select [name] from keyword where used between 10 and 50;/*这个不对，包括了10和50，用下面的才可以*/
select [name] from keyword where used >10 and used <50; 
 --如果被使用次数（Used）小于等于0，或者是NULL值，或者大于100的，将其更新为1
 begin tran
 update keyword set used=1
 where used<=0 or used is null or used >=100;
 rollback
    --删除所有使用次数为奇数的Keyword
begin tran 
delete [keyword] where used%2=1;
rollback
select *from keyword;