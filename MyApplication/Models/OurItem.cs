using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApplication.Models
{
    public class OurItem
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string CategoryId { get; set; }
        public string TypeId { get; set; }
        public string Price { get; set; }
        public string HalfPrice { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? Active { get; set; }
    }
}