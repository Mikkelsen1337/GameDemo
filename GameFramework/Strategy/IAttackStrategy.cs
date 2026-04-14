using GameFramework.Items.Attack;

namespace GameFramework.Strategy
{
    public interface IAttackStrategy
    {
        int CalculateDamage(List<AttackItem> items);
    }
}