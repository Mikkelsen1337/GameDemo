using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework.Items.Attack
{
    public class AttackItem
    {
        public string Name { get; set; }
        public int Damage { get; set; }

        public AttackItem(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
    }
}
