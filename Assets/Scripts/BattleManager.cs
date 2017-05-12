using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour {

	//int turn = 0; //0:プレイヤー、1:エネミー
	
	public Text inWhiteBox;

	public PlayerScript player;
	public EnemyScript enemy;

	// Use this for initialization
	void Start () {
		//inWhiteBox.text = "やせいのスライムが現れた";
		player.Damage(enemy.param.attack);
	}
	
	// Update is called once per frame
	

	//void attack(){
		
	//}
}
