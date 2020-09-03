--//创建一个表 register
CREATE TABLE [dbo].register
(
[ID] INT NOT NULL,
[name] NVARCHAR(10) NOT NULL,
[PASSWORD] NVARCHAR(12)  NOT NULL,
[INviter] NVARCHAR(4) NOT NULL,
)
--//增加表中的数据
ALTER TABLE [register]
ADD  AGE INT NOT NULL
--//删除表中的数据
ALTER TABLE [register]
DROP COLUMN PASSWORD
--///修改表中的数据
ALTER TABLE [register]
ALTER COLUMN AGE NVARCHAR(10) NULL
--////删除表
DROP TABLE [register];