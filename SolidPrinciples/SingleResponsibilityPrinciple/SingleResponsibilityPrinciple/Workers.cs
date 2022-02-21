using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class Workers
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Workertype workertype { get; set; }

    }

    public enum Workertype
    {
        Cooker,
        Mechanic,
        Cleaner
    }
}
