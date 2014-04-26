using UnityEngine;
using System.Collections;

public class Enemy_Generator : MonoBehaviour {

	public GameObject enemy_1;
	public float cd_unit_1 = 1f;
	private float timer_1;
	private bool gen_1 = true;
	public int unit_level_1 =0;
	public int incremento = 10;

	public GameObject player;

	public int actual_level = 0;
	public float timer_level;
	public float cd_level= 0;
	private bool gen_level = false;

	void FixedUpdate(){
	if (gen_1 == false) {
		if (Time.time >= timer_1)
				gen_1 = true;
	}
		if (gen_level == false) {
			if (Time.time >= timer_level) {		
				gen_level = true;
				unit_level_1 = actual_level*incremento + 5 + incremento;
	
			}
		}
	}

	// Use this for initialization

	// Update is called once per frame
	void Update () {
		if (gen_level == true) {
			if (gen_1 == true && unit_level_1 > 0) {

				float x = Random.Range(-8, 8);
				if(x > 0) x=8;
				else x = -8;
				float y = Random.Range(-5, 5);
				Instantiate (enemy_1, new Vector3 (x, y, 1), Quaternion.identity);
				unit_level_1 --;
				timer_1 = Time.time + cd_unit_1;
				gen_1 = false;
			} 

			if (unit_level_1 == 0) {
				timer_level = Time.time + cd_level;		
				actual_level++;
				gen_level = false;
				cd_unit_1 -=0.01f;
			}
		}
	}
}
