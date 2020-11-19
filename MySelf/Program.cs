using System;
using System.Collections;

namespace MySelf
{
    public class human
    {




        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy年MM月dd日hh时mm分ss秒"));

            int a=30;

            int b = 20;
            Console.WriteLine(a%b);

           





            //students lzb = new students();
            //foreach (var item in lzb)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }

   

    class students /*: IEnumerable*////实现IEnumerable接口就可以躲过编译时检查，不报错，但运行时会报错
    {                            ///不写后面这个接口名也没事，只要在类中实现了GetEnumerator()方法就可以了


        //public class StudentsEnumerator : IEnumerator  ///类中类实现返回一个
        //{
        //    public object[] ages = new object[] { 12, 34, 56, 75, 332 };
        //    private int index = -1;
        //    public object Current
        //    {
        //        get
        //        {
        //            return ages[index];
        //        }
        //    }

        //    public bool MoveNext()
        //    {
        //        index++;
        //        return index < ages.Length;
        //    }

        //    public void Reset()
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //public IEnumerator GetEnumerator()
        //{
        //    return new StudentsEnumerator();
        //}
    }
}







