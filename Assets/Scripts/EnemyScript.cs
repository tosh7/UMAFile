using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	public CharacterParam param;

	public void Attack(int damage){
		Debug.Log ("自分の攻撃" + damage + "のダメージ");
		param.hp -= damage;
		Debug.Log (param.name + "は" + param.hp);
	}

	public void Magic(int damage){
		Debug.Log ("自分は呪文を唱えた"  + damage + "のダメージ");
		param.hp -= damage;
		Debug.Log (param.name + "は" + param.hp);
	}
}
