using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class Works
    {
        public void Cook(string workerName)
        {
                System.Console.WriteLine(workerName + "Yemek Pişiriyor");     
        }
        public void Clean(string workerName)
        {
                System.Console.WriteLine(workerName + "Temizlik Yapıyor");
        }
        public void Repair(string workerName)
        {
                System.Console.WriteLine(workerName + "Tamirat Yapıyor"); 
        }

    }
}
