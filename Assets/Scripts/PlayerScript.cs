using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {
	int item;

	public CharacterParam param;
	//public ParameterContoroller pC;
	//public GameObject pcObj;
	public Text inWhiteBox;
	//float timer =  0.0f;
	private int nowHp;
	private int nowMp;
	private int nowItem;
	private string key1 = "nowhp";
	private string key2 = "nowmp";
	private string key3 = "ITEM";


	void Start(){
		//pC = pcObj.GetComponent<ParameterContoroller>();

		//pC.ParamUpdate (param.name, param.hp, param.mp);
	
		nowHp = PlayerPrefs.GetInt (key1, param.maxHp); 
		nowMp = PlayerPrefs.GetInt (key2, param.maxMp);
		nowItem = PlayerPrefs.GetInt (key3, 5);

//		Debug.Log ("Battle Start"+nowHp.ToString());

		param.hp = nowHp;
		param.mp = nowMp;
		item = nowItem;

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
		if (item > 0) {
			param.hp += cure;

			ParameterContoroller.Instance.InBoxUpdate (param.name + "は" + cure + "だけHPを回復した");
			Debug.Log (param.name + "は" + cure + "だけHPを回復した");
			ParameterContoroller.Instance.ParamUpdate (param.name, param.hp, param.mp);
		} else {
			ParameterContoroller.Instance.InBoxUpdate ("しかし、もう薬草はなかった");
		}
	}

	public void Item3(){
		if (item > 0) {
			item -= 1;

			ParameterContoroller.Instance.InBoxUpdate (inWhiteBox.text = "残りの薬草は" + item + "個");
			Debug.Log ("残りの薬草は" + item + "個");
		} else {
			ParameterContoroller.Instance.InBoxUpdate ("HPは回復しない");
		}
	}

	public void save(){
//		Debug.Log ("save!"+param.hp);
		PlayerPrefs.SetInt (key1, param.hp);
		PlayerPrefs.SetInt (key2, param.mp);
		PlayerPrefs.SetInt (key3, item);
		PlayerPrefs.Save ();
	}


		
}
