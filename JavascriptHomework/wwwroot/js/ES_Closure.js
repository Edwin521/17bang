//在函数student()中声明了函数域变量name、age和female，使用闭包机制，将其暴露到函数外部
function student() {
    var name = "李智博";
    age = 25;
    female = false;
    return function () {
        return `姓名是${name},年龄是${++age},性别是${female}`;
    }
}
var getStudentInf = student();
console.log(`这里是该同学的身份信息：${getStudentInf()}`)
//1,name...等变量没有在内部函数种声明。
//2,所以getStudentInf()被调用的时候，javascript解释器追逐层向函数外部寻找name...变量的的定义。
//3,此时的student()已经执行完毕，按理说其中声明的name...等变量已经被销毁。
//由于1,函数返回的是一个在它内部声明的函数
//   2,而且该内部函数还调用了其外部函数的变量。
//   3,这个链条的存在，导致js的解释器无法释放外部函数资源,延长了函数中变量的生命周期。
//"js闭包的出现"







//解释以下代码运行结果：（ condition ? <statement when true> : <statement when false>）
//function foo(x) {
//    var tmp = 3;
//    return function (y) {
//        x = x ? x + 1 : 1;
//        console.log(x + y + tmp);
//    }
//}

//var bar = foo(0);
//或者：var bar = foo(1);
//或者：var bar = foo(0);

//bar(0);

///var bar = foo(1)的结果为15;
///var bar = foo(0)的结果为14;
 
///bar(10)结果为13。
//1,第一遍先执行foo(-1)函数，x=-1,tmp=3,y找不到，开始向外找;
//2,第二遍执行bar(10)函数，由于闭包的影响，x变量的生命周期延长，
//此时y的值为10,x=-1+1=0,最后输出 0+10+3=13;




//改动以下代码，让其输出如图所示，并说明理由。
//function buildList(list) {
//    var result = [];
//    for (var i = 0; i < list.length; i++) {
//        result.push(function () {
//            console.log('item' + i + ': ' + list[i])
//        });
//    }
//    return result;
//}

//(function () {
//    var fnlist = buildList([1, 2, 3]);
//    for (var i = 0; i < fnlist.length; i++) {
//        fnlist[i]();
//    }
//})();

//要得到的效果是    iteam0:1
//                iteam1:2
//                iteam2:3 



function buildList(list) {
    var result = [];
    for (let i = 0; i < list.length; i++) {//变量声明var关键字改为let
        result.push(function () {
            console.log('item' + i + ': ' + list[i])
        });
    }
    return result;
}

(function () {
    var fnlist = buildList([1, 2, 3]);
    for (var i = 0; i < fnlist.length; i++) {
        fnlist[i]();
    }
})();


///下面的匿名函数使用了立即执行函数表达式（IIFE),()会让前面的函数立即执行，使i值固定，形成闭包，
//使用let声明变量，具有块级作用域，没有var 的变量提升问题。