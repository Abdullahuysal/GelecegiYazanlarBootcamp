using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkHomeWork.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Founder { get; set; }
        public int MarketValue { get; set; }
        public List<Employee>Employees { get; set; }
        public List<Department> Departments { get; set; }
    }
}
