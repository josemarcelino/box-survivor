using UnityEngine;
using System.Collections;

public class blockMovimentGenerator : MonoBehaviour {


	int speed = 3000;
	// Update is called once per frame
	void Start () {
		transform.rigidbody2D.AddForce (new Vector3 (10 * this.rigidbody2D.mass * speed*Time.deltaTime, 10 * this.rigidbody2D.mass * speed*Time.deltaTime, 0));

	}
}
