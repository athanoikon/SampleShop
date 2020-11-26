using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SampleShop.ProductManagement.Models.DatabaseContext
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Guid IdentificationNumber { get; set; }

        [ForeignKey(nameof(Category))]
        public int MainCategoryId { get; set; }
        public Category MainCategory { get; set; }
    }
}
