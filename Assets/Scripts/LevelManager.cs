using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
	public float waitToRespawn;

	public PlayerController thePlayer;
	
	public Text scoreText;

	public int scoreCount;
	
	//public ResetOnRespawn[] objectsToReset;

	public bool respawnCoActive;
	
    // Use this for initialization
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
		
		//objectsToReset = FindObjectsOfType<ResetOnRespawn>();
		
		if(PlayerPrefs.HasKey("ScoreCount"))
		{
			scoreCount = PlayerPrefs.GetInt("ScoreCount");
		}

		scoreText.text = "Score: " + scoreCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public IEnumerator RespawnCo()
	{
		thePlayer.gameObject.SetActive(false);
		
		yield return new WaitForSeconds(waitToRespawn);
		
		scoreCount = 0;
		scoreText.text = "Score: " + scoreCount;
		
		thePlayer.gameObject.SetActive(true);

		//for(int i = 0; i < objectsToReset.Length; i++)
		//{
		//	objectsToReset[i].gameObject.SetActive(true);
		//	objectsToReset[i].ResetObject();
		//}
	}

	public void AddScore(int scoreToAdd)
	{
		scoreCount += scoreToAdd;
		scoreText.text = "Score: " + scoreCount;
	}
}

