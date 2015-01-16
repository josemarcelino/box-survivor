using UnityEngine;
using System.Collections;

public class WeaponGenerator : MonoBehaviour {
	int speed = 3000;
    int reflectBlocksAvailable = 5;
	public GameObject reflectBlock;

	
	// Update is called once per frame
	void Update () {
		if(reflectBlocksAvailable > 0 && Input.GetKeyDown("space")){
			float x = this.transform.position.x + 0.4f;
			float y = this.transform.position.y + 0.4f;
			Instantiate(reflectBlock,new Vector3(x,y, 0) , Quaternion.identity);
			reflectBlocksAvailable--;
		}
	}
}
