using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBeam : MonoBehaviour
{
	public float respawnTime = 3f;
	
	public GameObject player;
	public GameObject[] beamPrefabs;
	public GameObject[] beams;
	
	private Vector3 offset;

	// Use this for initialization
    void Start () 
	{
		offset = transform.position - player.transform.position;
        StartCoroutine(beamWave()); 
    }
	
    private void spawnEnemy()
	{
		beams = new GameObject[beamPrefabs.Length];
		
        int i = Random.Range (0, beamPrefabs.Length);
        {
			beams[i] = Instantiate(beamPrefabs[i]) as GameObject;
			beams[i].transform.position = new Vector3(15 + player.transform.position.x + offset.x, Random.Range(-1.5f,1.5f), offset.z);
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
