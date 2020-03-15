using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontal;
    float vertical;
	
	public GameObject player;

    public float moveSpeed;
	public float autoMove;
	
	public LevelManager theLevelManager;
	
	private Animator animator;
	
	private Rigidbody2D rbody2D;
	
	
   // Use this for initialization
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
		
		animator = GetComponent<Animator>();
		
		theLevelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") >=0)
		{
			horizontal = 0;
			horizontal = Input.GetAxisRaw("Horizontal");
			vertical = Input.GetAxisRaw("Vertical");
		} 
		
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
		
		animator.SetFloat("Vertical", Input.GetAxisRaw("Vertical"));
    }

    void FixedUpdate()
    {
        rbody2D.velocity = new Vector2(autoMove + horizontal * moveSpeed, vertical * moveSpeed);
    }
}
