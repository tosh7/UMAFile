using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class PlayerMoveScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.DeleteAll ();
	}
	
	// Update is called once per frame
	void Update () {
		float x = CrossPlatformInputManager.GetAxisRaw ("Horizontal");

		float y = CrossPlatformInputManager.GetAxisRaw ("Vertical");
	
		//Vector2 direction = new Vector2 (x, y);

		//gameObject. += new Vector3 (x, y, 0) * Time.deltaTime * 10;

//		GetComponent<Rigidbody2D>().velocity = new Vector3 (x, y, 0) * Time.deltaTime * 10;
		GetComponent<Rigidbody2D>().velocity = new Vector2 (x, y) * 8;
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Enemy") {
			Destroy (other.gameObject); 
			SceneManager.LoadScene ("Battle1", LoadSceneMode.Additive);
		}


	}
		
}
