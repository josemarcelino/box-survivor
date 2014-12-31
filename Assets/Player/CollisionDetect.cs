using UnityEngine;
using System.Collections;

public class CollisionDetect : MonoBehaviour {
	public GameObject timer;
	public GameObject LosingSound;
	int alreadyLost = 0;
	// Use this for initialization
	void OnCollisionEnter2D(Collision2D c){

				if (c.gameObject.tag == "Enemy") {
						
					timer.GetComponent<Timer>().gaming = false;
					if(alreadyLost == 0)
						Instantiate(LosingSound, new Vector3 (0, 0, 1), Quaternion.identity);
					alreadyLost = 1;
				}

				if (c.gameObject.tag == "Map-Left") {

			  

				}

				if (c.gameObject.tag == "Map-Right") {
			
			
			
				}

				if (c.gameObject.tag == "Map-Up") {
			
			
			
				}

				if (c.gameObject.tag == "Map-Down") {
			
			
			
				}
		}
}
