using UnityEngine;

public abstract class Enemy : IAttackable
{
    public const int MaxHP = 100;
    protected int hp;
    public string Name { get; private set; }

    public Enemy(string name)
    {
        Name = name;
        hp = MaxHP;
    }

    public virtual void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp < 0) hp = 0;
        Debug.Log($"{Name} に {damage} ダメージ！ 残りHP: {hp}");
    }

    public bool IsDead => hp <= 0;
}
