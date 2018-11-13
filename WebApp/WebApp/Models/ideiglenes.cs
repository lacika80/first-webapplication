using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class ideiglenes
    {
        public static List<Item> lista = new List<Item>
        {
            new Item() { Id = 0, Name = "só", Quantity = 2, Unit = "kg", Done = true },
            new Item() { Id = 1, Name = "cukor", Quantity = 1, Unit = "kg", Done = false },
            new Item() { Id = 2, Name = "liszt", Quantity = 500, Unit = "gramm", Done = false },
            new Item() { Id = 3, Name = "kömény", Quantity = 1, Unit = "tasak", Done = false }
        };
    }
}