using System;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon1 = new Weapon("Phantom",20,20);
            Weapon weapon2 = new Weapon("Vandal", 25, 20);
            Weapon weapon3 = new Weapon("Operator", 50, 30);

            Soldier soldier1 = new Soldier("Abdullah", 100, 50, true,weapon1);
            Soldier soldier2 = new Soldier("Emre", 100, 50, true,weapon2);

            FightArea fightArea = new FightArea();
            fightArea.fight(soldier1, soldier2);
            
        }
    }
}
