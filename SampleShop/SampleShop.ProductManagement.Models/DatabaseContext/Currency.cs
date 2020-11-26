using System;
using System.Collections.Generic;
using System.Text;

namespace SampleShop.ProductManagement.Models.DatabaseContext
{
    public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char Symbol { get; set; }
    }
}
