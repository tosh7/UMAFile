using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour {

	//int turn = 0; //0:プレイヤー、1:エネミー
	
	public Text inWhiteBox;

	public PlayerScript player;
	public EnemyScript enemy;
	public int Odamage;

	// Use this for initialization
	void Start () {
		//inWhiteBox.text = "やせいのスライムが現れた";
		Debug.Log( "やせいのスライムが現れた\nコマンドを入力してください");
	}
		

	public void AttackButton(){
		Odamage = player.param.attack - enemy.param.defence;
		enemy.Attack (Odamage);
		EnemyAttack ();
		if (enemy.param.hp <= 0) {
			Debug.Log (enemy.param.name + "を倒した");
		}
	}

	public void MagicButton(){
		Odamage = player.param.attack - enemy.param.defence;
		Odamage = Odamage * 2;
		enemy.Magic (Odamage);
		EnemyAttack ();
		if (enemy.param.hp <= 0) {
			Debug.Log (enemy.param.name + "を倒した");
		}
	}

	public void ItemButton(){
		Odamage = 15;
		player.Item (Odamage);
		EnemyAttack ();
	}

	public void EnemyAttack(){
		if (enemy.param.hp > 0) {
			Odamage = enemy.param.attack - player.param.defence;
			player.Damage (Odamage, enemy.param.name);
		}
	}
		

}