using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class Weapon
    {
        public Weapon(string weaponName,int weaponAttackDamage,int weaponWeight)
        {
            WeaponName = weaponName;
            WeaponAttackDamage = weaponAttackDamage;
            WeaponWeight = weaponWeight;
        }
        public string WeaponName { get; set; }
        public int WeaponAttackDamage { get; set; }
        public int  WeaponWeight{ get; set; }
    }
}
