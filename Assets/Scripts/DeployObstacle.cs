using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployObstacle : MonoBehaviour
{
  public GameObject obstaclePrefab;
    public float respawnTime = 1.0f;
	public GameObject player;
	private Vector3 offset;

    // Use this for initialization
    void Start () {
		offset = transform.position - player.transform.position;
        StartCoroutine(asteroidWave());
    }
    private void spawnEnemy(){
        GameObject a = Instantiate(obstaclePrefab) as GameObject;
        a.transform.position = new Vector3(player.transform.position.x + offset.x, offset.y, offset.z);
    }
    IEnumerator asteroidWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}