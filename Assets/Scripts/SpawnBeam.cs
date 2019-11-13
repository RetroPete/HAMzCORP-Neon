using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBeam : MonoBehaviour
{
	public GameObject[] beamPrefabs;
	public GameObject[] beams;
	//public GameObject beamPrefab;
	//public Sprite[] beamSprites;
    public float respawnTime = 1.0f;
	public GameObject player;
	private Vector3 offset;

    void Start () 
	{
		offset = transform.position - player.transform.position;
        StartCoroutine(beamWave()); 
    }
	
    private void spawnEnemy()
	{
        //int arrayIdx = Random.Range (0, beamSprites.Length);
		//Sprite beamSprite = beamSprites[arrayIdx];
		//GameObject newBeam = Instantiate(beamPrefab);
		//newBeam.GetComponent<SpriteRenderer>().sprite = beamSprite;
		//newBeam.transform.position = new Vector3(15 + player.transform.position.x + offset.x, Random.Range(-3.5f,3.5f), offset.z);
		
		beams = new GameObject[beamPrefabs.Length]; //makes sure they match length
        //for (int i = 0; i < beamPrefabs.Length; i++)
		int i = Random.Range (0, beamPrefabs.Length);
        {
			beams[i] = Instantiate(beamPrefabs[i]) as GameObject;
			beams[i].transform.position = new Vector3(15 + player.transform.position.x + offset.x, Random.Range(-3.5f,3.5f), offset.z);
		}
    }
	
    IEnumerator beamWave()
	{
        while(true)
		{
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
