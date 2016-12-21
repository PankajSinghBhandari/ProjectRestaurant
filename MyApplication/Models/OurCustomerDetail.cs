using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApplication.Models
{
    public class OurCustomerDetail
    {

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string OrderId { get; set; }
        public string Price { get; set; }
        public string Comment { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}