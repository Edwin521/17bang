--使用子查询：

    --1找到从未成为邀请人的用户（当心NULL值）
    SELECT*FROM [USER]

    SELECT *FROM [USER]
    WHERE ID NOT IN (
    SELECT INVITEDBY FROM [USER]
    GROUP BY INVITEDBY
    )

   -- 2查出这些文章：其作者总共只发布过这一篇文章


   SELECT  *FROM problem

   SELECT*FROM problem WHERE AuthorId IN (
   
   SELECT AuthorId FROM problem
   GROUP BY AuthorId
   HAVING COUNT(title)=1



   )





    --3为求助添加一个发布时间（PublishTime），查找每个作者最近发布的一篇求助
    SELECT*FROM problem
    WHERE publishdatetime IN (
    SELECT MAX(publishdatetime) FROM problem
    GROUP BY AuthorId
    )
    --4查出每个作者悬赏最多的3篇求助
    SELECT *FROM problem WHERE ID NOT IN (

     SELECT COUNT(title), MAX(reward) ,AuthorId  FROM problem 
     group by AuthorId
)


SELECT ROW_NUMBER()      -- 排名函数
OVER(PARTITION BY AuThorId    -- 按Age进行分组（区，一个窗口）
     ORDER BY reward )     -- 组内按Score排序
AS GID,    
     -- 列名
FROM problem

    --5删除悬赏相同的求助（只要相同的全部删除一个不留）
       SELECT  *FROM problem
       SELECT *FROM [USER]
       BEGIN TRAN 
       DELETE problem WHERE ID IN(
       SELECT reward FROM problem
       GROUP BY reward
       HAVING COUNT(reward)>1
       )
       ROLLBACK


    --6删除每个作者悬赏最低的求助
    SELECT*FROM [problem]
    --------------------------aaa
    BEGIN TRAN
        DELETE problem WHERE ID IN(
    SELECT ID FROM problem OPB


    WHERE reward =(
    SELECT MIN(reward) FROM problem IPB
    WHERE OPB.AuthorId=IPB.AuthorId
    )
    )
    ROLLBACK
















    --分别使用派生表和CTE，查询求助表（表中只有一列整体的发布时间，没有年月的列），以获得：
        --1一起帮每月各发布了求助多少篇


    --2每月发布的求助中，悬赏最多的3篇

    --3每个作者，每月发布的，悬赏最多的3篇

    --4分别按发布时间和悬赏数量进行分页查询的结果