//设置一个常量password，保存你的密码
const password = { name: "李智博" };
//一起帮用户被分为5种，每种都有一个整数代号：
//0：访客
//1：注册用户
//2：文章发布者
//3：管理员
//4：超级管理员
//写一段代码，用switch...case将代号转换成文字输出，但3和4都统称“管理员”即可
let n ;
switch (n) {
    case 0:
        Console.log("访客");
        break;
    case 1:
        console.log("注册用户");
        break;
    case 2:
        console.log("文章发布者");
        break;
    case 3:
    case 4:
        console.log("管理员");
        break;
    default:
        console.log("系统出现未知错误");//兜底
}