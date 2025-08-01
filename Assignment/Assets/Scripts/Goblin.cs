public class Goblin : Enemy
{
    public Goblin(string name) : base(name) { }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage / 2); // ゴブリンは半分しかダメージ受けない
    }
}
