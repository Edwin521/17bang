using System;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{
    public class DLinkNode
    {

        public DLinkNode Previous { set; get; }
        public DLinkNode Next { get; set; }
        public void AddAfter(DLinkNode node)///在后面添加节点
        {

            if (this.Next != null)
            {
                node.Next = this.Next;
                this.Next.Previous = node;
            }
            node.Previous = this;
            this.Next = node;
        }

        public void AddBefore(DLinkNode node)//往前面添加节点
        {
            if (this.Previous != null)
            {
                node.Previous = this.Previous;
                node.Next = this;
                this.Previous.Next = node;
                this.Previous = node;

            }
            else
            {
                node.Next = this.Previous;
                this.Previous = node;
            }


        }

        public void Delete(DLinkNode node)//删除一个节点
        {
            //这道题得判断删的节点是前一个还是后一个两种情况
            ///this的前一个的再前一个是否是空值
            if (this.Previous.Previous == null)//删除前面的
            {

                this.Previous = null;
            }
            else if (this.Previous.Previous != null)
            {
                this.Previous = node.Previous;
                node.Next = node.Previous.Next;

            }
            else if (this.Next.Next == null)///删除后面的
            {
                this.Next = null;

            }
            else
            {
                this.Next = node.Next;
                node.Previous = node.Next.Previous;
            }


        }

        public void Swap(DLinkNode node1, DLinkNode node2)///交换两个节点
        {
            ////1.如果两个节点都是处于末端的节点
            ///2，一个节点是处在末端，另一个节点处在中间
            ///3，两个节点都处在中间且相邻
            ///4，两个节点都处在中间不相邻
            ///   [1]   3   [2] 

            if ((node1.Previous == null) && (node2.Next == null))//如果两个节点都是处于末端的节点
            {
                this.Previous = this.Next;
                this.Next = this.Previous;
                node2.Next = this;
                node1.Previous = this;
                node1.Next = null;
                node2.Previous = null;


            }
            if ((node1.Previous != null) && (node2.Next == null))//一个节点在末端，一个节点在中间 0 [1] 3 [2]
            {
                this.Next = this.Previous;
                this.Previous = this.Next;
                node2.Next = this;
                node1.Previous = this;
                node1.Next = null;
                node2.Previous = node1.Previous;
                node1.Previous.Next = node2;
  
            }
            if ((node1.Previous!=null)&&(node2.Next!=null)) //两个节点都处在中间且相邻  [0]  [1] [2] [3]
            {
                node2.Previous = this;
                node2.Next = this.Next;

                node1.Next = node2.Next;
                node2.Previous = this.Next.Next;
                
                node1 = node2.Next.Previous;
                this.Next = node2;

            }

        }

    }
}
