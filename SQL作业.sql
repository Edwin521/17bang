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