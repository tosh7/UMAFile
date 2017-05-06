using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterParam{

	public string name;
	public int hp;
	public int hpMax;
	public int attack;

	public CharacterParam(){
	}

	//初期化するとき
	public CharacterParam(int hp1, int attack){
		this.hp = hp1;
		this.attack = attack;
	}
}
