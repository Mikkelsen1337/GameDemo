using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework.Items.Defence
{
    public class DefenceItem
    {
        public string Name { get; set; }
        public int ReduceDamage { get; set; }

        public DefenceItem(string name, int reduce)
        {
            Name = name;
            ReduceDamage = reduce;
        }
    }
}
