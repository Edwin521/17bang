//含参构造函数，能给当前实例的属性赋值：时间（datetime = 当前时间），玩家Id（playerName）和成绩（score）
//静态方法：getBest(playName) ，返回一个score对象
//实例方法：save()
//以及：一个整数值bestOfAll
class Score {

    constructor(Id, score) {
        this.datetime = new Date;
        this.Id = Id;
        this.score = score;
    }
    ///类中方法不需要写function关键字，直接写函数名参数;
    static getBest(playName) {
        let max = playName[0].score;
        let arr2 = [];
        for (var i = 0; i < playName.length; i++) {
            arr2[i] = playName[i].score;//我想把score数据倒到一个排序相同的数组中
            var cur = playName[i].score;
            cur > max ? max = cur : null;
            //arr2.indexOf(max);//相应的对象数组最大值的下标
        }
        ///数组中的是对象，不是一个个数字
        //console.log(arr2);

        return playName[arr2.indexOf(max)];//返回的就是成绩最好的对象
    }
    save() {
        console.log(`Id为${this.Id}的账号已经保存`)
    }
}
let lzb = new Score(1, 32);
let zl = new Score(2, 34);
let lw = new Score(3, 33);
let arr = [lzb, zl, lw];
lzb.save();
Score.getBest(arr);

