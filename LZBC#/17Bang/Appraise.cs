using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{
    public class Appraise<T> : IAppraise<T> where T:Content
    {
        public AppraiseDirection Direction { get; private set; }
        public T Article { get; set; }
        public User Voter { get; set; }
      
     
        public void Agree() { }
        public void Disagree() { }
       


    }
    public enum AppraiseDirection
    {
        Up,
        Down
    }

}
