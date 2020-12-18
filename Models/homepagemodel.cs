using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class homepagemodel
    {
        public int Prod_Price { get; set; }

        public int Order_Amount { get; set; } = 0;
        public int Prod_ID { get; set; } 
        public string ImagePath { get; set; }
        public string Prod_Name { get; set; }

    }
}