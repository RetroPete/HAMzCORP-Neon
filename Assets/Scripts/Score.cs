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
		if(other.tag == "beam_b(Clone)")
		{
			theLevelManager.AddScore(scoreValue);

		}
		
		if(other.tag == "beam_g(Clone)")
		{
			theLevelManager.AddScore(scoreValue);

		}
		
		if(other.tag == "beam_p(Clone)")
		{
			theLevelManager.AddScore(scoreValue);

		}
		
		if(other.tag == "beam_r(Clone)")
		{
			theLevelManager.AddScore(scoreValue);

		}
	}
}

