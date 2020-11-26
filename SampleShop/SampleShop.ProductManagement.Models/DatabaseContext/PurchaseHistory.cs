using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SampleShop.ProductManagement.Models.DatabaseContext
{
    public class PurchaseHistory
    {
        public int Id { get; set; }
        public string Description { get; set; }

        [ForeignKey(nameof(PurchaseHistoryType))]
        public int HistoryTypeId { get; set; }
        public PurchaseHistoryType HistoryType { get; set; }
    }
}
