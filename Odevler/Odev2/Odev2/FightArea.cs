using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class FightArea
    {
        public FightArea()
        {

        }
        
      

        public void fight(Soldier soldier1,Soldier soldier2)
        {
            while (soldier1.IsAlive==true && soldier2.IsAlive==true)
            {
                Random random = new Random();
                int AttacksoldierNumber = random.Next(1, 2);
                if (AttacksoldierNumber == 1)
                {
                    Console.WriteLine(soldier1.Name + "Saldırıyor"+soldier2.Name+"'a"); 
                    soldier1.Attack(soldier1, soldier2);
                }
                else
                {
                    Console.WriteLine(soldier2.Name + "Saldırıyor" + soldier1.Name + "'a");
                    soldier2.Attack(soldier2, soldier1);
                }
            }
            if (soldier1.IsAlive)
            {
                WinnerSoldier(soldier1.Name);
            }
            else
            {
                WinnerSoldier(soldier2.Name);
            }
        }

        public void WinnerSoldier(string soldiername)
        {
            Console.WriteLine("kazanan askerin adı:"+soldiername);
        }
    }
}
