n--使用子查询：

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
    WHERE PUBLISHTIME IN (
    SELECT MAX(PUBLISHTIME) FROM problem
    GROUP BY AuthorId
    )
     
    --4查出每个作者悬赏最多的3篇求助


SELECT*FROM problem
SELECT title,reward FROM 
(
SELECT ROW_NUMBER() OVER(PARTITION BY Author ORDER BY reward desc) seq ,reward ,title from [problem] 
) ds
 WHERE ds.seq<=3



    --5删除悬赏相同的求助（只要相同的全部删除一个不留）
       SELECT  *FROM problem
       SELECT *FROM [USER]
  
       DELETE problem WHERE reward IN(
       SELECT reward FROM problem
       GROUP BY reward
       HAVING COUNT(reward)>1
       )



    --6删除每个作者悬赏最低的求助
    SELECT*FROM [problem]
    --------------------------aaa
    begin tran
        DELETE problem WHERE ID IN(
    SELECT ID FROM problem OPB


    WHERE reward =(
    SELECT MIN(reward) FROM problem IPB
    WHERE OPB.AuthorId=IPB.AuthorId
    )
    )
 















    --分别使用派生表和CTE，查询求助表（表中只有一列整体的发布时间，没有年月的列），以获得：
        --1一起帮每月各发布了求助多少篇


       SELECT YEAR (PUBLISHTIME),MONTH(PUBLISHTIME),COUNT(*) FROM problem
       GROUP BY YEAR(PUBLISHTIME),MONTH(PUBLISHTIME)
       ORDER BY YEAR(PUBLISHTIME),MONTH(PUBLISHTIME)




GO

--月份一致的没显示在一行
 SELECT YEAR(PUBLISHTIME)[YEAR],
        MONTH(PUBLISHTIME)[MONTH] ,
        COUNT(title) NUM 
    FROM ( SELECT PUBLISHTIME,title FROM problem )op

     GROUP BY  YEAR(PUBLISHTIME),MONTH(PUBLISHTIME)
 



 




    --2每月发布的求助中，悬赏最多的3篇


    SELECT*FROM (

     SELECT ROW_NUMBER() OVER(PARTITION BY YEAR(PUBLISHTIME),MONTH(PUBLISHTIME) ORDER BY reward) GID,
    YEAR(PUBLISHTIME)[YEAR],
    MONTH(PUBLISHTIME)[MONTH],
    title,reward
    ) OP
    WHERE OP.GID<=3

 


    GO

    WITH query
    AS(
    SELECT ROW_NUMBER() OVER(PARTITION BY YEAR(PUBLISHTIME),MONTH(PUBLISHTIME) ORDER BY reward) GID,
    YEAR(PUBLISHTIME)[YEAR],
    MONTH(PUBLISHTIME)[MONTH],
    title,
    reward
    FROM problem

    
    )
    SELECT*FROM query
    WHERE GID<=3

    GO




        --ELECT ROW_NUMBER() OVER(PARTITION BY Author ORDER BY reward desc) seq
  




    --3每个作者，每月发布的，悬赏最多的3篇
    SELECT *FROM problem

     GO

    WITH query
    AS(
    SELECT ROW_NUMBER() OVER(PARTITION BY AuthorId ORDER BY reward) GID,
    YEAR(PUBLISHTIME)[YEAR],
    MONTH(PUBLISHTIME)[MONTH],
    AuthorId,title,reward
    FROM problem
    )
   
    SELECT *FROM query
    WHERE GID<=3


    GO


    SELECT*FROM(
     SELECT ROW_NUMBER() OVER(PARTITION BY AuthorId ORDER BY reward) GID,
    YEAR(PUBLISHTIME)[YEAR],
    MONTH(PUBLISHTIME)[MONTH],
    AuthorId,title,reward
    FROM problem
    ) P
    WHERE P.GID<=3

    --4分别按发布时间和悬赏数量进行分页查询的结果
    --按悬赏数量
    SELECT*FROM  problem
    GO
    WITH query
    AS(
    SELECT ROW_NUMBER() OVER( ORDER BY reward DESC ) GID,
            YEAR(PUBLISHTIME)[YEAR],
             MONTH(PUBLISHTIME)[MONTH],*

    FROM problem
    )
    SELECT *FROM query
    WHERE GID BETWEEN 1 AND 3

    SELECT*FROM problem
    ORDER BY reward DESC


    GO
    --按发布时间排序
     WITH query
    AS(
    SELECT ROW_NUMBER() OVER( ORDER BY PUBLISHTIME DESC ) GID,
            YEAR(PUBLISHTIME)[YEAR],
             MONTH(PUBLISHTIME)[MONTH],*

    FROM problem
    )
    SELECT *FROM query
    WHERE GID BETWEEN 1 AND 3

    SELECT*FROM problem
    ORDER BY PUBLISHTIME DESC

    GO
    --按时间排序分页查询
    SELECT *FROM problem ORDER BY PUBLISHTIME
    OFFSET 2 ROWS
    FETCH NEXT 3 ROWS ONLY
   --按悬赏排序分页查询

   SELECT*FROM problem ORDER BY reward
   OFFSET 2 ROWS
   FETCH NEXT 3 ROWS ONLY

     --按时间排序分页查询
     SELECT *FROM problem ORDER BY PUBLISHTIME

     SELECT  TOP 3 *FROM problem
     WHERE ID NOT IN
            (SELECT TOP 2 ID FROM problem ORDER BY PUBLISHTIME      )
     ORDER BY PUBLISHTIME
       --按悬赏排序分页查询
        SELECT *FROM problem ORDER BY reward

        SELECT TOP 2 *FROM problem
        WHERE reward NOT IN 
        (
        SELECT TOP 2  reward FROM problem ORDER BY reward
        )
        ORDER BY reward

