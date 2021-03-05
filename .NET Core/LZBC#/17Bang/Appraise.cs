using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LZBC
{
    public class Appraise
    {
        public AppraiseDirection Direction { get; private set; }

        public User Voter { get; set; }


        public void Agree()
        {
            this.Voter.HelpDot++;
            Direction = AppraiseDirection.Up;
        }
        public void Disagree()
        {
            this.Voter.HelpDot++;
            Direction = AppraiseDirection.Down;
        }

    }
    public enum AppraiseDirection
    {
        Up,
        Down
    } 
}



