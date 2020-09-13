 --在User表上的基础上：


    --添加Id列，让Id成为主键
   
    ALTER TABLE [user]
    ADD [id] INT PRIMARY KEY IDENTITY;

    
    SELECT *FROM [user]
    --添加约束，让UserName不能重复
    ALTER TABLE [user]
    ADD CONSTRAINT UQ_username UNIQUE(username);

--在Problem表的基础上：

    --为NeedRemoteHelp添加NOT NULL约束，再删除NeedRemoteHelp上NOT NULL的约束
    ALTER TABLE [problem]
    ALTER COLUMN needremotehelp bit NOT NULL;

    ALTER TABLE [problem]
    ALTER COLUMN needremotehelp bit;

    --添加自定义约束，让Reward不能小于10
    ALTER TABLE [problem]
    ADD CONSTRAINT CK_reward CHECK(reward>=10);
