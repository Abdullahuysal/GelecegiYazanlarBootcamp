using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public  class Soldier
    {
        public string Name{ get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public bool IsAlive { get; set; }

        public Weapon Weapon { get; set; }

        public Soldier()
        {

        }
        public Soldier(string name,int health,int armor,bool isAlive,Weapon weapon)
        {
            Name = name;
            Health = health;
            Armor = armor;
            IsAlive = isAlive;
            Weapon = weapon;
        }
        public void Attack (Soldier mySoldier,Soldier enemy)
        {
            enemy.Health = enemy.Health - mySoldier.Weapon.WeaponAttackDamage;
            if (enemy.Health < 0)
            {
                enemy.IsAlive = false;
            }
        }



    }
        
}
