using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_b : MonoBehaviour
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
		if(other.gameObject.name == "Shield_b")
        {
            theLevelManager.AddScore(scoreValue);
        }
	}
}

