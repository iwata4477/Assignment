using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class Player
{
    public string Name { get; private set; }

    public Player(string name)
    {
        Name = name;
    }

    public async Task AttackAsync(List<IAttackable> enemies)
    {
        var target = enemies
            .Where(e => !e.IsDead)
            .OrderBy(e => Random.Range(0, 100)) // ランダムで選ぶ
            .FirstOrDefault();

        if (target == null)
        {
            Debug.Log("攻撃対象がいない！");
            return;
        }

        Debug.Log($"{Name} が {target.Name} に攻撃中…");
        await Task.Delay(1000); // 疑似的な非同期処理

        int damage = Random.Range(10, 30);
        target.TakeDamage(damage);
    }
}
