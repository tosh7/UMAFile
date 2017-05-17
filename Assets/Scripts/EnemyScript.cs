using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour {

	public CharacterParam param;
	//public Text inWhiteBox;

	/*void OnCollisonEnter(Collision other){		
		StartCoroutine ("Attack", other.collider.name);
	}*/



	public void Attack(int damage){
		Debug.Log ("自分の攻撃" + damage + "のダメージ");
		//inWhiteBox.text = "自分の攻撃" + damage + "のダメージ";
		ParameterContoroller.Instance.InBoxUpdate ("自分の攻撃" + damage + "のダメージ");
		//yield return new WaitForSeconds (2.0f);
		param.hp -= damage;
		Debug.Log (param.name + "は" + param.hp);
		/*if (param.hp <= 0) {
			Debug.Log (param.name + "を倒した");
			//inWhiteBox.text = param.name + "を倒した";
			ParameterContoroller.Instance.InBoxUpdate (param.name + "を倒した");
		}*/
	}

	public void Magic(int damage){
		Debug.Log ("自分は呪文を唱えた"  + damage + "のダメージ");
		//inWhiteBox.text = "自分は呪文を唱えた" + damage + "のダメージ";
		ParameterContoroller.Instance.InBoxUpdate ("自分は呪文を唱えた" + damage + "のダメージ");
		param.hp -= damage;
		Debug.Log (param.name + "は" + param.hp);
		/*if (param.hp <= 0) {
			Debug.Log (param.name + "を倒した");
			//inWhiteBox.text = param.name + "を倒した";
			ParameterContoroller.Instance.InBoxUpdate (param.name + "を倒した");
		}*/
	}
}
