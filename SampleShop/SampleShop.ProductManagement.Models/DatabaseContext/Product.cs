using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SampleShop.ProductManagement.Models.DatabaseContext
{
    public class Product
    {
        public Product()
        {
            Purchases = new HashSet<PurchaseHistory>();
        }

        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Product))]
        public int LinkedProductId { get; set; }
        public virtual Product LinkedProduct { get; set; }

        [ForeignKey(nameof(Country))]
        public int ManufactureCountryId { get; set; }
        public Country ManufactureCountry { get; set; }

        [ForeignKey(nameof(Flag))]
        public int ProductFlagId { get; set; }
        public Flag ProductFlag { get; set; }

        [ForeignKey(nameof(SubCategory))]
        public int ProductSubCatecoryId { get; set; }    
        public SubCategory ProductSubCatecory { get; set; }


        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

        [ForeignKey(nameof(Currency))]
        public int LocalCurrencyId { get; set; }
        public Currency LocalCurrency { get; set; }

        public virtual HashSet<PurchaseHistory> Purchases { get; set; }

    }
}
