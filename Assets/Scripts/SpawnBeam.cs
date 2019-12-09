using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBeam : MonoBehaviour
{
	public GameObject[] beamPrefabs;
	public GameObject[] beams;
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
		beams = new GameObject[beamPrefabs.Length];
        
		int i = Random.Range (0, beamPrefabs.Length);
        {
			beams[i] = Instantiate(beamPrefabs[i]) as GameObject;
			beams[i].transform.position = new Vector3(10 + player.transform.position.x + offset.x, Random.Range(-1.5f,1.5f), offset.z);
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
