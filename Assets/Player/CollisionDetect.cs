using UnityEngine;
using System.Collections;

public class CollisionDetect : MonoBehaviour {
	public GameObject timer;
	// Use this for initialization
	void OnCollisionEnter2D(Collision2D c){

				if (c.gameObject.tag == "Enemy") {
						
			timer.GetComponent<Timer>().gaming = false;

				}
		}
}
