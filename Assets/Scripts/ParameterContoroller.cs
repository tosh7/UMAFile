using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParameterContoroller : MonoBehaviour {

	public Text gage;
	public Text inWhiteBox;
	//List<string> inBoxList;
	//float timer = 0.0f;

	/*void Start() {
		inBoxList = new List<string> ();

	}*/

	public void ParamUpdate (string name, int hp, int mp) {
		gage.text = name + "\nHP:" + hp.ToString () + "\nMP:" + mp.ToString ()
		+ "\nLv.23";
	}

	public static ParameterContoroller Instance = null;

	void Awake(){
		if (Instance == null) {
			Instance = this;
			// 他のシーンに移動しても消えない
		} else {
			Destroy(this.gameObject);
			// 2つ以上存在しないようにする
		}
	}

	public void InBoxUpdate(string input){
		inWhiteBox.text = input;
		//inBoxList.Add (input);

	}

	/*void Update(){
		if (inBoxList.Count >= 1) {
			if (timer <= 0.0f) {
				inWhiteBox.text = inBoxList [0];

				inBoxList.RemoveAt (0);
				timer = 2.0f;
			}


		}
		timer -= Time.deltaTime;
	}

	IEnumerator DisplayText(){

		while (inBoxList.Count >= 1) {			
			inWhiteBox.text = inBoxList [0];
			//yield return new WaitForSeconds (2.0f);
			inBoxList.RemoveAt (0);
		}
	}*/





}