using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployObstacle : MonoBehaviour
{
	public GameObject obstaclePrefab;
    public float respawnTime = 1.0f;
	public GameObject player;
	private Vector3 offset;

    void Start () {
		offset = transform.position - player.transform.position;
        StartCoroutine(asteroidWave());
    }
    private void spawnEnemy(){
        GameObject a = Instantiate(obstaclePrefab) as GameObject;
        a.transform.position = new Vector3(20 + player.transform.position.x + offset.x,Random.Range(-3.5f, 3.5f), offset.z);
    }
    IEnumerator asteroidWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}