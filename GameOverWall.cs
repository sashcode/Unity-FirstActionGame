using UnityEngine;
using System.Collections;

public class GameOverWall : MonoBehaviour
{
	
	void OnTriggerEnter (Collider collision)
	{
		GameObject manager = GameObject.Find ("/GameManager");
		manager.SendMessage ("GameOver");
	}
}
