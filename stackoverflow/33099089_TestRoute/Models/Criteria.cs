using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestRoute.Models
{
    public class Criteria
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MyClass MyProp { get; set; }
    }
}