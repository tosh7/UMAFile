using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour {

	//int turn = 0; //0:プレイヤー、1:エネミー

	public Text inWhiteBox;

	public PlayerScript player;
	public EnemyScript enemy;
	public int damage;

	// Use this for initialization
	void Start () {
		inWhiteBox.text = "やせいのスライムが現れた";
		Debug.Log( "やせいのスライムが現れた\nコマンドを入力してください");
	}
		

	public void AttackButton(){
		damage = player.param.attack - enemy.param.defence;
		enemy.Attack (damage);
		EnemyAttack ();

	}

	public void MagicButton(){
		damage = player.param.attack - enemy.param.defence;
		damage = damage * 2;
		enemy.Magic (damage);
		EnemyAttack ();

	}

	public void ItemButton(){
		damage = 15;
		player.Item (damage);
		EnemyAttack ();
	}

	public void EnemyAttack(){
		if (enemy.param.hp > 0) {
			damage = enemy.param.attack - player.param.defence;
			player.Damage (damage, enemy.param.name);
		}
	}
		

}