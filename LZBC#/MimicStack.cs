using System;
using System.Collections.Generic;
using System.Text;

namespace MimicStack
{

    // 自己实现一个模拟栈（MimicStack）类，入栈出栈数据均为int类型，包含如下功能：
    // 1出栈Pop()，弹出栈顶数据
    //2入栈Push()，可以一次性压入多个数据
    //3出/入栈检查，
    //    (1)如果压入的数据已超过栈的深度（最大容量），提示“栈溢出”
    //    (2)如果已弹出所有数据，提示“栈已空”

    class MimicStack
    {

        public static int [] stack = new int[10];
        int top = 0;//最上边
        int bottom = 0;//最下边
        public void pop()
        {


        }
       internal static void Push(int value)
        {



            for (int i = 0; i < stack.Length; i++)
            {
                if (stack[i] == null)
                {
                    stack[i] = value;
                    return;
                }
            }






        }
    }
}
