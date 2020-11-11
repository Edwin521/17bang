using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{
    public class DLinkNode
    {

        public DLinkNode Previous { set; get; }
        public DLinkNode Next { get; set; }
      

        public void Delete()//删除一个节点
        {
           

        }

        public void Swap(DLinkNode node)///交换两个节点
        {
            ////1.如果两个节点都是处于末端的节点
            ///2，一个节点是处在末端，另一个节点处在中间
            ///3，两个节点都处在中间且相邻
            ///4，两个节点都处在中间不相邻

            ///   1 2 3 4 5    [5] 2 3 4 [1]
            if ((this.Previous == null || this.Next == null) && (node.Next == null || node.Previous == null))//如果两个节点都是处于末端的节点
            {
               //交换之前，this假设相当于1，传入的node是5；
                this.Next = null;
                this.Previous = node.Previous;
                node.Previous = null;
                node.Next = this.Next;
                this.Next.Previous = node;
                node.Previous.Next = this;
            
                


            }
            //一个节点在末端，一个节点在中间，且这两个节点是相邻的进行交换
            
            node.Next = node.Previous;
            node.Previous = null;
            this.Next = node.Next;
            this.Previous = this.Next;
            node.Next.Previous = this;

            //一个节点在末端，一个节点在中间，且这两个节点不相邻
            node.Previous = null;
            node.Next = this.Next;
            this.Previous = this.Next;
            this.Next = node.Next;
     




        }

    }
}
