select *from problem;


    --在Problem中插入不同作者（Author）不同悬赏（Reward）的若干条数据，以便能完成以下操作：

    alter table problem
    add Author nvarchar(30) 

    insert problem([id],title,content,needremotehelp,reward,publishdatetime,Author) values (6,N'sql','aaaaa',1,45,2020-8-8,N'李胜利'); 
    insert problem([id],title,content,needremotehelp,reward,publishdatetime,Author) values (7,N'ql','aaaaa',1,48,2020-8-8,N'飞哥');
    insert problem([id],title,content,needremotehelp,reward,publishdatetime,Author) values (8,N'sql','aaaaa',1,90,2020-8-8,N'李有才');
    insert problem([id],title,content,needremotehelp,reward,publishdatetime,Author) values (9,N'sql','aaaaa',1,87,2020-8-8,N'飞哥');
    insert problem([id],title,content,needremotehelp,reward,publishdatetime,Author) values (10,N'sql数据库','bbbb',1,107,2020-8-10,N'飞哥');

    --    查找出Author为“飞哥”的、Reward最多的3条求助

    select  top 3 * from problem where Author=N'飞哥'
    order by reward desc;
    --    所有求助，先按作者“分组”，然后在“分组”中按悬赏从大到小排序

    select Author ,reward from problem
    order by Author  ,reward DESC;
    --    查找并统计出每个作者的：求助数量、悬赏总金额和平均值
    SELECT Author as '作者', Count(title) as '求助数量',Sum(reward) as '悬赏总金额',AVG(reward) as '平均值' from problem
    Group By Author
    order by Author ASC
    SELECT*FROM problem;
    --    找出平均悬赏值少于10的作者并按平均值从小到大排序
    SELECT Author,AVG(reward)AS average from problem    
    group by Author
    HAVING  AVG(reward)<50
    order by average ASC;
      
 
    --以Problem中的数据为基础，使用SELECT INTO，新建一个Author和Reward都没有NULL值的新表：NewProblem （把原Problem里Author或Reward为NULL值的数据删掉）
   
    SELECT Author,reward
    INTO NewProblem
    FROM problem WHERE Author IS not NULL  and reward  is not null; 


     --SELECT *FROM NewProblem

    --使用INSERT SELECT, 将Problem中Reward为NULL的行再次插入到NewProblem中


 --   SELECT * FROM problem
 --UPDATE problem SET Author=N'这是测试数据2',reward = NULL WHERE ID=2;



    INSERT NewProblem
    SELECT Author,reward FROM problem where reward is null;
   
    
