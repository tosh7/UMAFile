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

	void Update(){
		

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Odamage = player.param.attack - enemy.param.defence;
			enemy.Attack (Odamage);
			if (enemy.param.hp > 0) {
				Odamage = enemy.param.attack - player.param.defence;
				player.Damage (Odamage);
			}
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Odamage = player.param.attack - enemy.param.defence;
			Odamage = Odamage * 2;
			enemy.Magic (Odamage);
			if (enemy.param.hp > 0) {
				Odamage = enemy.param.attack - player.param.defence;
				player.Damage (Odamage);
			}
		} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Odamage = 15;
			player.Item (Odamage);
			if (enemy.param.hp > 0) {
				Odamage = enemy.param.attack - player.param.defence;
				player.Damage (Odamage);
			}
		}


	}

	/*public void AttackButton(){
		Odamage = player.param.attack - enemy.param.defence;
		enemy.Attack (Odamage);
		Debug.Log ("Push");
	}

	public void MagicButton(){
		Debug.Log ("Push2");
	}*/
		

}