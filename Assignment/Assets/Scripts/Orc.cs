public class Orc : Enemy
{
    public Orc(string name) : base(name) { }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage); // オークは普通に受ける
    }
}
