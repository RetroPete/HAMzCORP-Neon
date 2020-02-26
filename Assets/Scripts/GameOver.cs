﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string levelSelect;
	public string mainMenu;

	private LevelManager theLevelManager;

	// Use this for initialization
	void Start () 
	{
		theLevelManager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void Restart()
	{
		PlayerPrefs.SetInt("ScoreCount", 0);

		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void QuitToMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
