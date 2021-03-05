//建立第一个module：score.js，里面有一个类score：
//含参构造函数，能给当前实例的属性赋值：时间（datetime = 当前时间），玩家Id（playerName）和成绩（score）
//静态方法：getBest(playName) ，返回一个score对象
//实例方法：save()
//以及：一个整数值bestOfAll


//建立又一个module：user.js，里面有：
//三个属性：用户Id（Id）、昵称（name）、密码（password）
//一个静态方法：getNameById(id) ，返回一个字符串
//一个实例方法：login(name, password) ，返回一个整数值
//score.js对外所有成员，但bestOfAll对外名称为record
//user.js默认对外暴露login() ，另外暴露getNameById() ，隐藏其他属性
//score.js中的getBest()利用user.js的getNameById() ，将玩家名称转换成Id
//生成一个“打地鼠”（Mole）页面，在页面中：
//引用上述module方法，调用其公开成员
//使用图片替换的方式实现打地鼠功能（图片见群文件