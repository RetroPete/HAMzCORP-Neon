using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void NewGame()
	{
		SceneManager.LoadScene("Level_1");

		PlayerPrefs.SetInt("ScoreCount", 0);
	}

	public void Continue()
	{
		SceneManager.LoadScene("Level_1");
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}