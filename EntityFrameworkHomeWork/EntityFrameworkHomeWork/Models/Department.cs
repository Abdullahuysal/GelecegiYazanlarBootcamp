using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkHomeWork.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
        public Location Location { get; set; }
        public int LocationId { get; set; }



    }
}
