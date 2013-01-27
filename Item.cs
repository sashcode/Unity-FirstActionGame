using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour
{

	void OnTriggerEnter (Collider collision)
	{
		AudioSource source = GetComponent<AudioSource> ();
		source.Play ();
		StartCoroutine ("DesableObject");
		renderer.enabled = false;
	}
	
	IEnumerator DesableObject ()
	{
		yield return new WaitForSeconds(1);
		gameObject.SetActive (false);		
	}

}
