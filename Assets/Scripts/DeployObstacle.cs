using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployObstacle : MonoBehaviour
{
  public GameObject obstaclePrefab;
    public float respawnTime = 10.0f;
    private Vector2 cameraBounds;

    // Use this for initialization
    void Start () {
		//need to find camera bounds here...
        cameraBounds = Camera.main.WorldToScreenPoint(new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }
    private void spawnEnemy(){
        GameObject a = Instantiate(obstaclePrefab) as GameObject;
        a.transform.position = new Vector2(cameraBounds.x * -2, Random.Range(-cameraBounds.y, cameraBounds.y));
    }
    IEnumerator asteroidWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}