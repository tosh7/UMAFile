using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour {

	int turn = 0; // 0:プレイヤーの攻撃　1:敵の攻撃

	public Script1 player;
	public Script2 enemy;


	void Start(){
		// 敵からの攻撃
		player.Damage(enemy.param.attack);
	}

	void PlayerAttack(){
		//enemy.Damage ();


	}

	void EnemyAttack()
	{
	}
}
