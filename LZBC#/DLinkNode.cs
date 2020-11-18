using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{
    public class DLinkNode : IEnumerable
    {



        public DLinkNode Next { get; set; }
        public DLinkNode Previous { get; set; }
        public int value;
        public bool IsEnd { get { return Next == null; } }
        public bool IsFirst { get { return Previous == null; } }
        //在节点后插入节点node
        public void AddAfter(DLinkNode node)
        {
            //1 2] 3 4
            if (this.Next != null)
            {
                node.Next = this.Next;
                //  node.Previous = this;
                this.Next.Previous = node;
                //  this.Next = node;
            }

            node.Previous = this;
            this.Next = node;


        }

        //在该节点前插入节点node
        public void InsretBefor(DLinkNode node)
        {
            if (this.Previous != null)
            {
                node.Previous = this.Previous;
                this.Previous.Next = node;
            }
            node.Next = this;
            this.Previous = node;
        }

        //删除当前节点
        public void Delete()
        { //  1 2- 【3】
            DLinkNode oldPre = this.Previous;
            DLinkNode oldNex = this.Next;
            if (oldPre != null)
            {
                oldPre.Next = oldNex;

            }
            if (oldNex != null)
            {
                oldNex.Previous = oldPre;
            }
            this.Previous = this.Next = null;

        }
        //交换节点
        public void Swap(DLinkNode targetNode)
        {

            DLinkNode prethis = this.Previous;
            DLinkNode nextthis = this.Next;
            this.Delete();
            if (nextthis == targetNode)
            {
                targetNode.AddAfter(this);
            }
            else if (prethis == targetNode)
            {
                targetNode.InsretBefor(this);
            }
            else /*if (nextthis != targetNode && prethis != targetNode)*/
            {
                targetNode.AddAfter(this);
                targetNode.Delete();
                if (prethis == null)
                {
                    nextthis.InsretBefor(targetNode);
                }
                else
                {
                    prethis.AddAfter(targetNode);

                }
            }



        }

        public IEnumerator GetEnumerator()
        {
            return new NodeIEnumerator(this.Previous);
        }

    }

    public class NodeIEnumerator : IEnumerator
    {
        private DLinkNode node;
        private bool end;
        public object Current{get{return node.Previous;} }
        public NodeIEnumerator(DLinkNode node)
        {
            this.node = node;
        }
        public bool MoveNext()
        {
            if (end)
            {
                return false;
            }
            if (node.IsEnd)
            {
                DLinkNode FackTail = new DLinkNode();
                FackTail.AddAfter(node);
                end = true;
            }
            node = node.Next;
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
