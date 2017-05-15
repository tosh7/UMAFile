using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParameterContoroller : MonoBehaviour {

	public Text gage;

	public void ParamUpdate (string name, int hp, int mp) {
		gage.text = name + "\nHP:" + hp.ToString () + "\nMP:" + mp.ToString ()
		+ "\nLv.23";
	
	}


}