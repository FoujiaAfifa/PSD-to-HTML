using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQConsoleApp
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public string Brand { get; internal set; }
    }
}