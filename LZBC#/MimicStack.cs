using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{

    // 自己实现一个模拟栈（MimicStack）类，入栈出栈数据均为int类型，包含如下功能：
    // 1出栈Pop()，弹出栈顶数据
    //2入栈Push()，可以一次性压入多个数据
    //3出/入栈检查，
    //    (1)如果压入的数据已超过栈的深度（最大容量），提示“栈溢出”
    //    (2)如果已弹出所有数据，提示“栈已空”

    public class MimicStack
    {

        private int[] container;
        public MimicStack(int length)
        {
            container = new int[length];
        }
        int top = 0;//最上边
        //const int bottom = 0;//最下边
        public int pop()
        {
            if (top != 0)
            {
                top--;
                return container[top];
            }
            else
            {
                return -1;//栈已空
            }

        }
        public void Push(int element)
        {
            if (top <= container.Length - 1)
            {
                container[top] = element;
                top++;
            }
            else
            {
                Console.WriteLine("stack Overflow");
            }
        }

        public void Push( params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Push(array[i]);
            }
        }



    }
}
