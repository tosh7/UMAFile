using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class parameter{
	public int MaxHp = 100;
	public int MaxMp = 50;
	public Text gage;
	public static int hp;
	public static int mp;
	//public static int sp = 15;



	// Use this for initialization
	void Start () {
		hp = MaxHp;
		mp = MaxMp;
	}
	
	// Update is called once per frame
	void Update () {
		gage.text = "とし\nHP:" + hp.ToString() + "\nMP:" + mp.ToString()
		+ "\nLv.23";
	}
}
