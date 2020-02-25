using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private LevelManager theLevelManager;

	public int scoreValue;

	// Use this for initialization
	void Start () {
		theLevelManager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Shield_b")
		{
			theLevelManager.AddScore(scoreValue);

		}
		
		if(other.tag == "Shield_g")
		{
			theLevelManager.AddScore(scoreValue);

		}
		
		if(other.tag == "Shield_p")
		{
			theLevelManager.AddScore(scoreValue);

		}
		
		if(other.tag == "Shield_r")
		{
			theLevelManager.AddScore(scoreValue);

		}
	}
}

