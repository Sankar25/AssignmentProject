using System;
using System.ComponentModel.DataAnnotations;

namespace homeservice.api.Models
{
    public class Category
    {
        [Key]
        public long CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
