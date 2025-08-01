public interface IAttackable
{
    void TakeDamage(int damage);
    bool IsDead { get; }
    string Name { get; }
}
