using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace homeservice.api.Models
{
    public class CategoryServices
    {
        [Key]
        public long CategoryServiceId { get; set; }

        public string CategoryServiceName { get; set; }

        public long CategoryTypeId { get; set; }

        public CategoryType CategoryType { get; set; }
    }
}
