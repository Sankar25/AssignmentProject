using System;
using System.Collections.Generic;
using System.Text;

namespace HomeServiceModels
{
    public class ServiceRequests
    {
        public string Name { get; set; }

        public long CategoryId { get; set; }

        public Category Category { get; set; }

        public long CategoryTypeId { get; set; }

        public CategoryType CategoryType { get; set; }

        public TimeSpan ServieTiming { get; set; }
    }
}
