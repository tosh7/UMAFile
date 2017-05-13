using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	int item = 5;

	public CharacterParam param;

	public void Damage(int damage, string enemyName){
		Debug.Log (enemyName + "の攻撃" + damage + "のダメージ");
		param.hp -= damage;
		Debug.Log (param.name + "は" + param.hp);
	}

	public void Item(int cure){
		param.hp += cure;
		item -= 1;
		Debug.Log (param.name + "は薬草を使った");
		Debug.Log (param.name + "は" + cure + "だけHPを回復した");
		Debug.Log (param.name + "は" + param.hp);
		Debug.Log("残りの薬草は" + item + "個");
	}


}
