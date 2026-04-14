using GameFramework.Items.Attack;
using GameFramework.Items.Defence;
using GameFramework.World;
using GameFramework.Strategy;
using GameFramework.Utils;
using System;
using System.Collections.Generic;

namespace GameFramework.Creatures
{
    public abstract class Creature
    {
        public event Action<string>? OnHit;
        public event Action<string>? OnDeath;

        public string Name { get; set; }
        public int HitPoints { get; set; }

        public List<AttackItem> AttackItems { get; set; }
        public List<DefenceItem> DefenceItems { get; set; }

        public IAttackStrategy AttackStrategy { get; set; }

        public Creature(string name, int hp)
        {
            Name = name;
            HitPoints = hp;
            AttackItems = new List<AttackItem>();
            DefenceItems = new List<DefenceItem>();
            AttackStrategy = new NormalAttackStrategy();
        }

     
        public int PerformAttack()
        {
            int damage = CalculateDamage();

            ApplyAttackEffects();

            return damage;
        }

     
        protected virtual int CalculateDamage()
        {
            return AttackStrategy.CalculateDamage(AttackItems);
        }

        protected virtual void ApplyAttackEffects()
        {
            Console.WriteLine("testttt Temp Method testttttttttt");
        }


        public int Hit()
        {
            return PerformAttack();
        }

        public void ReceiveHit(int damage)
        {
            int reduced = damage;

            foreach (var defence in DefenceItems)
            {
                reduced -= defence.ReduceDamage;
            }

            if (reduced < 0) reduced = 0;

            HitPoints -= reduced;

            OnHit?.Invoke($"{Name} took {reduced} damage");

            Logger.Instance.Log($"{Name} took {reduced} damage");

            if (HitPoints <= 0)
            {
                Logger.Instance.Log($"{Name} died");
            }
        }

        public void Loot(WorldObject obj)
        {
            if (!obj.Lootable) return;
        }
    }
}