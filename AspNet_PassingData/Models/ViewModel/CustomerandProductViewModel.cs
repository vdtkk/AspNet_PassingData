using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_PassingData.Models.ViewModel
{
    public class CustomerandProductViewModel
    {
        public List<Customer> customers { get; set; }
        public Product product { get; set; }
        public string date { get; set; }
    }
}
