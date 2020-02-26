using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_g : MonoBehaviour
{
	public int scoreValue;
	
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

	void OnTriggerEnter2D(Collider2D other)
	{	
		if(other.gameObject.name == "Shield_g")
		{
			theLevelManager.AddScore(scoreValue);
		}
	}
}

