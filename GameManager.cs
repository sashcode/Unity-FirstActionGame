using UnityEngine;
using System.Collections;

public enum GameState
{
	GAME_CLEAR,
	GAME_OVER,
	GAME_RUNNING
}

public class GameManager : MonoBehaviour
{
	private GameState state;
	public GUIText mainText;
	public GUIText timeText;
	int count = 0;
	
	void Start ()
	{
		state = GameState.GAME_RUNNING;
		timeText.SendMessage("Run");
		mainText.text = "";
	}
	
	void Update ()
	{
		switch (state) {
		case GameState.GAME_RUNNING:
			break;
		case GameState.GAME_CLEAR:
			mainText.text = "Game Clear";
			timeText.SendMessage("Stop");
			WaitAndRestart ();
			break;
		case GameState.GAME_OVER:
			mainText.text = "Game Over";
			WaitAndRestart ();
			break;
		}
	}
	
	private void WaitAndRestart ()
	{
		count++;
		if (count > 300) {
			Application.LoadLevel ("scene");
		}
	}
	
	public void GameClear ()
	{
		state = GameState.GAME_CLEAR;
	}
	
	public void GameOver ()
	{
		state = GameState.GAME_OVER;
	}
}
