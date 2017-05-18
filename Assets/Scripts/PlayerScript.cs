using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {
	int item = 5;

	public CharacterParam param;
	//public ParameterContoroller pC;
	//public GameObject pcObj;
	public Text inWhiteBox;
	//float timer =  0.0f;
	private int nowHp;
	private int nowMp;
	private string key = "now";



	void Start(){
		//pC = pcObj.GetComponent<ParameterContoroller>();

		//pC.ParamUpdate (param.name, param.hp, param.mp);
		//PlayerPrefs.DeleteAll();

		nowHp = PlayerPrefs.GetInt (key, 100); 
		nowMp = PlayerPrefs.GetInt (key, 50);

		param.hp = nowHp;
		param.mp = nowMp;

		ParameterContoroller.Instance.ParamUpdate (param.name, param.hp, param.mp);
	}

	public void Damage(int damage, string enemyName){
		Debug.Log (enemyName + "の攻撃" + damage + "のダメージ");
		//yield return new WaitForSeconds (2.0f);
		//inWhiteBox.text = enemyName + "の攻撃" + damage + "のダメージ";
		ParameterContoroller.Instance.InBoxUpdate (enemyName + "の攻撃" + damage + "のダメージ");
		param.hp -= damage;
		Debug.Log (param.name + "は" + param.hp);
		//pC.ParamUpdate (param.name, param.hp, param.mp);
		ParameterContoroller.Instance.ParamUpdate (param.name, param.hp, param.mp);



	}

	public void Item1(){


		//Debug.Log (param.name + "は" + param.hp);

		/*inWhiteBox.text = param.name + "は薬草を使った";
		inWhiteBox.text = param.name + "は" + cure + "だけHPを回復した";
		inWhiteBox.text = "残りの薬草は" + item + "個";*/
			ParameterContoroller.Instance.InBoxUpdate (param.name + "は薬草を使った");
			Debug.Log (param.name + "は薬草を使った");
			
			

	}

	public void Item2(int cure){
		param.hp += cure;

		ParameterContoroller.Instance.InBoxUpdate (param.name + "は" + cure + "だけHPを回復した");
		Debug.Log (param.name + "は" + cure + "だけHPを回復した");
		ParameterContoroller.Instance.ParamUpdate (param.name, param.hp, param.mp);
	}

	public void Item3(){
		item -= 1;

		ParameterContoroller.Instance.InBoxUpdate (inWhiteBox.text = "残りの薬草は" + item + "個");
		Debug.Log("残りの薬草は" + item + "個");
	}

	public void save(){
		PlayerPrefs.SetInt (key, nowHp);
		PlayerPrefs.SetInt (key, nowMp);
	}
		
}
