﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _18bangServices.ViewModel
{
    public class SaleModel
    {
        public int LeftBMoney { set; get; }
        public int CanSale { set; get; }
        public string ByFrom { set; get; }
        public int SaleCount { set; get; }
        public int TotalSaleMoney { set; get; }
        public string Message { set; get; }
    }
}