using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Item
    {
        public string Name { get; internal set; }
        public int Quantity { get; internal set; }
        public string Unit { get; internal set; }
        public bool Done { get; internal set; }
    }
}