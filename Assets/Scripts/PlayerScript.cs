using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public CharacterParam param;

	public void Damage(int damage){
		Debug.Log ("敵の攻撃" + damage + "のダメージ");
		param.hp -= damage;
		Debug.Log (param.name + "は" + param.hp);
	}

}
