using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamController : MonoBehaviour
{
	public float speed = 1.0f;
	public float destroyTime = 6.5f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
	
	void Start () 
	{
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToViewportPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));	
    }

    // Update is called once per frame
   void Update () 
    {
        Destroy(GameObject.Find("Beam(Clone)"),destroyTime);	
	}
}	
