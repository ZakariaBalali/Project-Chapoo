﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemModel
{
    public class Item
    {
        public int itemID { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int tax { get; set; }
        public string foodtype { get; set; }
        public int stock { get; set; }
        public string course { get; set; }
        public string description { get; set; }

        public string comment { get; set; }

        
    }
}

