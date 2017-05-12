using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class CharacterParam{
	public string name;
	public int MaxHp;
	public int MaxMp;
	public Text gage;
	public int hp;
	public  int mp;
	public int attack;
	public int defence;
	//public static int speed;

	public CharacterParam(){

	}

	// Use this for initialization
	void Start () {
		//hp = MaxHp;
		//mp = MaxMp;
	}
	
	// Update is called once per frame
	void Update () {
		gage.text = "とし\nHP:" + hp.ToString() + "\nMP:" + mp.ToString()
		+ "\nLv.23";
	}
}
