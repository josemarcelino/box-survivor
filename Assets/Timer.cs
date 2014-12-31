using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	float start_timer;
	public bool gaming = true;
	float record = 0;
	Vector2 center = new Vector2(Screen.width / 2,Screen.height / 2);

	void Awake(){
		start_timer = Time.time;
		}
	void OnGUI () {
		float time_actual = 0;
				if (gaming == true) {
						time_actual = Time.time - start_timer;
						record = time_actual;
				}
				string gui = record.ToString();
				gui = GUI.TextField (new Rect (1, 1, 75, 20), gui, 25);
		if(gaming == false){
		
			if(GUI.Button (new Rect(center.x - (300/ 2),center.y - (100 / 2),300,100), "GAME OVER \n" + gui + " seconds")){
				  
					Application.LoadLevel(Application.loadedLevel);
			}
					else if(Input.GetKeyDown("enter")){
				Application.LoadLevel(Application.loadedLevel);
				}
			}

		}
	}




 
