using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{

    //设计一个类FactoryContext，保证整个程序运行过程中，无论如何，外部只能获得它的唯一的一个实例化对象。（提示：设计模式之单例） 

    //要实现单例模式，要有两个步骤；
    //1--让类不能创建实例


    //2--让类只能创建一个实例
    class FactoryContext
    {

       private FactoryContext()//创建构造器，并把访问权限声明为私有的,此时，我们再次进行实例化那么编译器就会报错
        {

        }
        public static FactoryContext instance;// 将instance声明为类A的一个静态成员，
                                                //因为声明为static的类成员或者成员函数便能在类的范围内同享 。
                                                //同时在Foo方法中写一个保护性的代码。
      

        public static FactoryContext foo() //Foo这个方法就被定义为静态成员方法，而静态成员方法与对象是无关的，
                                            //而是与类有关系。那么此时我们就可以在类外部调用这个方法。
        {
            if (instance==null)
            {
                instance = new FactoryContext();
            }
           
            return instance;
        }
    }
}
