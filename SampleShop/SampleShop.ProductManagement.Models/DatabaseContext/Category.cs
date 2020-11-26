using System;
using System.Collections.Generic;
using System.Text;

namespace SampleShop.ProductManagement.Models.DatabaseContext
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Guid IdentificationNumber { get; set; }
        public bool HasSubCategory { get; set; }
    }
}
