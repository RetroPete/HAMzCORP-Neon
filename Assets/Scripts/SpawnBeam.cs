using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBeam : MonoBehaviour
{
	public GameObject beamPrefab;
	public Sprite[] beamSprites;
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
        int arrayIdx = Random.Range (0, beamSprites.Length);
		Sprite beamSprite = beamSprites[arrayIdx];
		GameObject newBeam = Instantiate(beamPrefab);
		newBeam.GetComponent<SpriteRenderer>().sprite = beamSprite;
		newBeam.transform.position = new Vector3(20 + player.transform.position.x + offset.x, Random.Range(-3.5f,3.5f), offset.z);
		
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
