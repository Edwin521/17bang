   ---- 1 联表查出求助的标题和作者用户名
   SELECT*FROM [USER]
   SELECT * FROM problem P       -- *指的是Join过后两张表的所有列，s是给表Student的别名
JOIN [USER] U                  -- 给表City一个别名，使用JOIN  将Student和City连接起来
ON P.ID=U.ID      -- 指定表Student（别名s）和City（别名c）连接的条件
   -- 2 查找并删除从未发布过求助的用户
   -- 3 用一句SELECT显示出用户和他的邀请人用户名
   -- 4 -17bang的关键字有“一级”“二级”和其他“普通（三）级”的区别：
   --     1请在表Keyword中添加一个字段，记录这种关系
   --     2然后用一个SELECT语句查出所有普通关键字的上一级、以及上上一级的关键字名称，比如：

   -- 1-17bang中除了求助（Problem），还有意见建议（Suggest）和文章（Article），他们都包含Title、Content、PublishTime和Auhthor四个字段，但是：
   --     建议和文章没有悬赏（Reward）
   --     建议多一个类型：Kind NVARCHAR(20)）
   --     文章多一个分类：Category INT）
   -- 2 请按上述描述建表。然后，用一个SQL语句显示某用户发表的求助、建议和文章的Title、Content，并按PublishTime降序排列