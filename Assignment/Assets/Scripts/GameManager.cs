using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Player player;
    private List<IAttackable> enemies;

    async void Start()
    {
        // プレイヤー生成
        player = new Player("なのか");

        // 敵リスト作成（コレクション）
        enemies = new List<IAttackable>
        {
            new Goblin("ゴブリンA"),
            new Goblin("ゴブリンB"),
            new Orc("オークA"),
            new Orc("オークB")
        };

        // 攻撃を複数回繰り返す（簡単なループ処理）
        for (int i = 0; i < 5; i++)
        {
            await player.AttackAsync(enemies);
        }

        Debug.Log("攻撃終了！");
    }
}
