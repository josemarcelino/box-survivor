using UnityEngine;
using System.Collections;

public class MovingGenerator : MonoBehaviour {

	int speed = 3000;

	// Use this for initialization
	void Start () {

		float y = Random.Range (-5, 5);

		if (this.transform.position.x > 0) {
						float x = Random.Range (-1, -8);
			transform.rigidbody2D.AddForce (new Vector3 (x * speed*Time.deltaTime, y * speed*Time.deltaTime, 0));
				} 
		else {
						float x = Random.Range (1, 8);
			transform.rigidbody2D.AddForce (new Vector3 (x * speed*Time.deltaTime, y * speed*Time.deltaTime, 0));
				}

	}


	void OnCollision2D(Collider2D c){
		
		if (c.gameObject.tag == "Enemy")
			print ("GAME OVER");
		
		
	}




	

}
