using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	
	void OnTriggerEnter(Collider collision){
		GameObject manager = GameObject.Find ("/GameManager");
		manager.SendMessage ("GameClear");
	}
	
}
