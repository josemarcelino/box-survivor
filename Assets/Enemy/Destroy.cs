using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	int speed = 50;
	int howmany = 0;
	// Use this for initialization
	void Start () {
	
	}
	//////// COLISION DETECT CHICKEN
	void OnCollisionEnter2D(Collision2D c){
		
		if (c.gameObject.tag == "Map-Up" || c.gameObject.tag == "Map-Bot" || c.gameObject.tag == "Map-Left" || c.gameObject.tag == "Map-Right") {
			howmany++;
		}
	}
	// Update is called once per frame
	void Update () {
		if (howmany > 2)
			Destroy (this.gameObject);
	}


}
