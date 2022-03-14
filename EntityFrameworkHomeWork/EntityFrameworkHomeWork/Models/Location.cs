using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkHomeWork.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public int PostCode { get; set; }
        public List<Department>Departments{ get; set; }
        public City City { get; set; }
        public int CityId { get; set; }


    }
}
