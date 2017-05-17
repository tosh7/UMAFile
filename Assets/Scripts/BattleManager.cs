using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BattleManager : MonoBehaviour {

	//int turn = 0; //0:プレイヤー、1:エネミー

	//public Text inWhiteBox;

	public PlayerScript player;
	public EnemyScript enemy;
	public int damage;

	// Use this for initialization
	void Start () {
		//inWhiteBox.text = "やせいのスライムが現れた";
		ParameterContoroller.Instance.InBoxUpdate ("やせいのスライムが現れた");
		Debug.Log( "やせいのスライムが現れた\nコマンドを入力してください");

	}
		

	public void AttackButton(){
		
		StartCoroutine ("AttackButtonPush");
	}

	IEnumerator AttackButtonPush(){
		damage = player.param.attack - enemy.param.defence;
		enemy.Attack (damage);

		yield return new WaitForSeconds(1.0f);

		if (enemy.param.hp <= 0) {
			Debug.Log (enemy.param.name + "を倒した");
			//inWhiteBox.text = param.name + "を倒した";
			ParameterContoroller.Instance.InBoxUpdate (enemy.param.name + "を倒した");
			yield return new WaitForSeconds (2.0f);
			SceneManager.LoadScene ("dungeon1");
		} else {
			EnemyAttack ();
		}

	}

	public void MagicButton(){
		StartCoroutine ("MagicButtonPush");
	}

	IEnumerator MagicButtonPush(){
		damage = player.param.attack - enemy.param.defence;
		damage = damage * 2;
		enemy.Magic (damage);
		player.param.mp -= 10;
		ParameterContoroller.Instance.ParamUpdate (player.param.name, player.param.hp, player.param.mp);

		yield return new WaitForSeconds(1.0f);

		if (enemy.param.hp <= 0) {
			Debug.Log (enemy.param.name + "を倒した");
			//inWhiteBox.text = param.name + "を倒した";
			ParameterContoroller.Instance.InBoxUpdate (enemy.param.name + "を倒した");
			yield return new WaitForSeconds (2.0f);
			SceneManager.LoadScene ("dungeon1");
		} else {
			EnemyAttack ();
		}
	}


	public void ItemButton(){
		StartCoroutine ("ItemButtonPush");
	}

	IEnumerator ItemButtonPush(){
		damage = 15;
		player.Item1 ();
		yield return new WaitForSeconds (2.0f);

		player.Item2 (damage);
		yield return new WaitForSeconds (2.0f);

		player.Item3 ();
		yield return new WaitForSeconds (2.0f);

		EnemyAttack ();
	}

	public void EnemyAttack(){
		if (enemy.param.hp > 0) {
			damage = enemy.param.attack - player.param.defence;
			player.Damage (damage, enemy.param.name);
		}
	}
		

}