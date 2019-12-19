using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace homeservice.api.Models
{
    public class ServiceRequests
    {
        [Key]
        public long ServiceRequestId { get; set; }
        public string Name { get; set; }

        public long CategoryId { get; set; }

        public Category Category { get; set; }

        public long CategoryTypeId { get; set; }

        public CategoryType CategoryType { get; set; }

        public long CategoryServiceId { get; set; }

        public CategoryServices CategoryServices { get; set; }

        public string ServiceTiming { get; set; }
    }
}
