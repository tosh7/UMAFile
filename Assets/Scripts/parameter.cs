using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class parameter : MonoBehaviour {
	public static int hp = 100;
	public static int mp = 50;
	public Text gage;
	public static int sp = 15;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gage.text = "とし\nHP:" + hp.ToString() + "\nMP:" + mp.ToString()
		+ "\nLv.23";
	}
}
