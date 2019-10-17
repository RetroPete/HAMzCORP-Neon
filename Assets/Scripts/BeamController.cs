using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamController : MonoBehaviour
{
<<<<<<< Updated upstream:Assets/Scripts/ObstacleController.cs
  public float speed = 1.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;


    // Use this for initialization
    void Start () {
=======
	public float speed = 1.0f;
	public float destroyTime = 6.5f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    void Start () 
	{
>>>>>>> Stashed changes:Assets/Scripts/BeamController.cs
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToViewportPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));	
    }
<<<<<<< Updated upstream:Assets/Scripts/ObstacleController.cs

    // Update is called once per frame
   void Update () {
     if(transform.position.x < screenBounds.x * -2){
         Destroy(this.gameObject);	
		}
    }
}
=======
	
    // Update is called once per frame
   void Update () 
    {
        Destroy(GameObject.Find("Beam(Clone)"),destroyTime);	
	}
}
	
>>>>>>> Stashed changes:Assets/Scripts/BeamController.cs
