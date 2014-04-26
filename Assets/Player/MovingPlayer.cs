using UnityEngine;
using System.Collections;

public class MovingPlayer : MonoBehaviour {


	public static float speed = 10;
	public GameObject timer;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

						if (Input.GetKey (KeyCode.UpArrow)) {
			if(this.transform.position.y < 3.9)
								this.transform.Translate (new Vector3 (0, 1, 0) * Time.deltaTime * speed);

						}

						//move up
		if (Input.GetKey (KeyCode.DownArrow )) {
			if( this.transform.position.y > -3.5)
								this.transform.Translate (new Vector3 (0, -1, 0) * Time.deltaTime * speed);

						}
						//move down
						if (Input.GetKey (KeyCode.RightArrow)) {
			if(this.transform.position.x < 7.8)
								this.transform.Translate (new Vector3 (1, 0, 0) * Time.deltaTime * speed);
						}

						//move right

		if (Input.GetKey (KeyCode.LeftArrow)) {
			if(this.transform.position.x > -7.85)
				this.transform.Translate (new Vector3 (-1, 0, 0) * Time.deltaTime * speed);

						}

		if(timer.GetComponent<Timer>().gaming == false){
				Destroy(this);
			}//move left
	
	}
}