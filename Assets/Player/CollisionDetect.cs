using UnityEngine;
using System.Collections;

public class CollisionDetect : MonoBehaviour {
	public GameObject timer;
	public GameObject LosingSound;
	int alreadyLost = 0;

	// Use this for initialization
	void OnCollisionEnter2D(Collision2D c){

				if (c.gameObject.tag == "Enemy") {
					
						timer.GetComponent<Timer> ().gaming = false;
						if (alreadyLost == 0)
								Instantiate (LosingSound, new Vector3 (0, 0, 1), Quaternion.identity);
			            this.gameObject.rigidbody2D.fixedAngle=false;
						alreadyLost = 1;
				}

				if (c.gameObject.tag == "Map-Up") {

						//this.gameObject.GetComponent("MovingPlayer").blockUp = true;
					MovingPlayer.blockUp = true;

				}

		if (c.gameObject.tag == "Map-Bot") {
		
			       MovingPlayer.blockDown = true;
		
				}

				if (c.gameObject.tag == "Map-Right") {
		
					MovingPlayer.blockRight = true;
		
				}

				if (c.gameObject.tag == "Map-Left") {
		
					MovingPlayer.blockLeft = true;
		
				}

		}
	void OnCollisionExit2D(Collision2D c){

			if (c.gameObject.tag == "Map-Up") {
				
				MovingPlayer.blockUp = false;
				
			}
			
			if (c.gameObject.tag == "Map-Bot") {
				
				MovingPlayer.blockDown = false;
				
			}
			
			if (c.gameObject.tag == "Map-Right") {
				
				MovingPlayer.blockRight = false;
				
			}
			
			if (c.gameObject.tag == "Map-Left") {
				
				MovingPlayer.blockLeft = false;
				
			}
		}
	}