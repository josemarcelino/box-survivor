using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	int speed = 50;
	public GameObject enemy_1;
	// Use this for initialization
	void Start () {
	
	}

	/*void OnTriggerEnter2D(Collider2D c){
		
		if (c.gameObject.tag == "Enemy") {
			Instantiate (enemy_1, new Vector3 (this.transform.position.x,this.transform.position.y, 1), Quaternion.identity);
			Instantiate (enemy_1, new Vector3 (this.transform.position.x,this.transform.position.y, 1), Quaternion.identity);
			Instantiate (enemy_1, new Vector3 (this.transform.position.x,this.transform.position.y, 1), Quaternion.identity);

		}
	}*/
	// Update is called once per frame
	void Update () {
		if (this.transform.position.x > 9 || this.transform.position.x < -9 || this.transform.position.y > 6 || this.transform.position.y < -6)
			DestroyObject(this.gameObject);
	}


}
