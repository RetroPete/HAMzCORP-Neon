using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
  public float speed = 1.0f;
    private Rigidbody2D rb;
    private Vector2 PlayerPos;
	public GameObject player;

    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        PlayerPos = new Vector2(player.transform.position.x,player.transform.position.y);
		
    }

    // Update is called once per frame
   void Update () {
     if(transform.position.x < PlayerPos.x - 2){
         Destroy(this.gameObject);	
		}
    }
}
