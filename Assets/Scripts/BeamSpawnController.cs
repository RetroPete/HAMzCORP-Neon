using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamSpawnController : MonoBehaviour
{
	public GameObject beam;
	public GameObject[] beamPrefab;
    public float respawnTime = 4.0f;
	public GameObject player;
	private Vector3 offset;

    void Start () 
	{
		offset = transform.position - player.transform.position;
        StartCoroutine(beamWave()); 
    }
	
    private void spawnEnemy()
	{
		beam = Instantiate(beamPrefab[0]) as GameObject;
		beam.transform.position = new Vector3(20 + player.transform.position.x + offset.x, Random.Range(-3.5f,3.5f), offset.z);
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