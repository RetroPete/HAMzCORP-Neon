using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_g : MonoBehaviour
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
		if(other.gameObject.name == "Shield_g")
		{
			theLevelManager.AddScore(scoreValue);
		}
	}
}

