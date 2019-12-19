using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace homeservice.api.Models
{
    public class CategoryType
    {
        [Key]
        public long CategoryTypeId { get; set; }

        public string CategoryTypeName { get; set; }

        public long CategoryId { get; set; }

        public Category category { get; set; }
    }
}
