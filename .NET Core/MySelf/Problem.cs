﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MySelf
{
   public class Problem :Content
    {
     
        public IList<Keyword> keywords { get; set; }
        public int Reward { set; get; }

        public string AuthorId { set; get; }
        public User Author { set; get; }
        public int? HaveKindId { set; get; }
        public Kind HaveKind { set; get; }


        public ProblemStatus Status { set; get; }
    }
    public enum ProblemStatus
    {
        [Description("已撤销")]
        cancelled,
        [Description("已酬谢")]
        Rewarded,
        [Description("协助中")]
        inprocess,
        [Description("待协助")]
        assist
    }
}
