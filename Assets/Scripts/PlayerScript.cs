using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {
	int item = 5;

	public CharacterParam param;
	public ParameterContoroller pC;
	public GameObject pcObj;
	public Text inWhiteBox;

	void Start(){
		pC = pcObj.GetComponent<ParameterContoroller>();
		pC.ParamUpdate (param.name, param.hp, param.mp);
	}

	public void Damage(int damage, string enemyName){
		Debug.Log (enemyName + "の攻撃" + damage + "のダメージ");
		inWhiteBox.text = enemyName + "の攻撃" + damage + "のダメージ";
		param.hp -= damage;
		Debug.Log (param.name + "は" + param.hp);
		pC.ParamUpdate (param.name, param.hp, param.mp);
	}

	public void Item(int cure){
		param.hp += cure;
		item -= 1;
		Debug.Log (param.name + "は薬草を使った");
		Debug.Log (param.name + "は" + cure + "だけHPを回復した");
		Debug.Log (param.name + "は" + param.hp);
		Debug.Log("残りの薬草は" + item + "個");
		inWhiteBox.text = param.name + "は薬草を使った";
		inWhiteBox.text = param.name + "は" + cure + "だけHPを回復した";
		inWhiteBox.text = "残りの薬草は" + item + "個";
	}


}
