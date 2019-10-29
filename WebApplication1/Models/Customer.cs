using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebApplication1.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Strasse { get; set; }
        public string PLZOrt { get; set; }
    }
}