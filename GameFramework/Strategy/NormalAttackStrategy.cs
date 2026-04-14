using GameFramework.Items.Attack;

namespace GameFramework.Strategy
{
    public class NormalAttackStrategy : IAttackStrategy
    {
        public int CalculateDamage(List<AttackItem> items)
        {
            int total = 0;

            foreach (var item in items)
            {
                total += item.Damage;
            }

            return total;
        }
    }
}