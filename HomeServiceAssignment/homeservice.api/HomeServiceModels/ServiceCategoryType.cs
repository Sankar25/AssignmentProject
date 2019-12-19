using System;
using System.Collections.Generic;
using System.Text;

namespace HomeServiceModels
{
    public class CategoryType
    {
        public int CategoryTypeId { get; set; }

        public string CategoryTypeName { get; set; }

        public string CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
