using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{
    public class Appraise<T> : IAppraise<T>
    {
        public AppraiseDirection Direction { get; set; }
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
