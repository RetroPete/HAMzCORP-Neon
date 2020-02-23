using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamController : MonoBehaviour
{
	public float speed = 1.0f;
	public float destroyTime = 6f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
	public GameObject beam; // This is where you reference the beam you want to destroy
	
	void Start () 
	{
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToViewportPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));	
    }

    // Update is called once per frame
    void Update () 
    {
        Destroy(GameObject.Find("beam_b(Clone)"), destroyTime);
		Destroy(GameObject.Find("beam_g(Clone)"), destroyTime);		
		Destroy(GameObject.Find("beam_p(Clone)"), destroyTime);
		Destroy(GameObject.Find("beam_r(Clone)"), destroyTime);
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Shield_b")
		{
			Destroy(GameObject.Find("beam_b(Clone)"));
		}
		else if (other.tag == "Player")
		{
			Application.LoadLevel("Level_1");
		}
		
		if(other.tag == "Shield_g")
		{
			Destroy(GameObject.Find("beam_g(Clone)"));
		}
		else if (other.tag == "Player")
		{
			Application.LoadLevel("Level_1");
		}
		
		if(other.tag == "Shield_p")
		{
			Destroy(GameObject.Find("beam_p(Clone)"));
		}
		else if (other.tag == "Player")
		{
			Application.LoadLevel("Level_1");
		}
		
		if(other.tag == "Shield_r")
		{
			Destroy(GameObject.Find("beam_r(Clone)"));
		}
		else if (other.tag == "Player")
		{
			Application.LoadLevel("Level_1");
		}
	
	}	
}
