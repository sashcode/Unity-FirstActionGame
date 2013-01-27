using UnityEngine;
using System.Collections;

public enum TimeEnum
{
	RUNNING,
	STOP
}

public class GameTime : MonoBehaviour
{
	private TimeEnum state = TimeEnum.STOP;
	private float startTime;

	public void Run ()
	{
		startTime = Time.time;
		state = TimeEnum.RUNNING;
	}
	
	public void Stop ()
	{
		state = TimeEnum.STOP;
	}
	
	void Update ()
	{
		switch (state) {
		case TimeEnum.RUNNING:
			float time = Time.time - startTime;
			guiText.text = time.ToString ("n2");
			break;
		case TimeEnum.STOP:
			break;
		}
	}
}
