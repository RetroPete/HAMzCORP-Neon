﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontal;
    float vertical;

    public float moveSpeed;
	public float autoMove;
	public GameObject player;
	
	private Rigidbody2D body2d;
	private Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        body2d = GetComponent<Rigidbody2D>();
		myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal")>=0)
		{
		horizontal = 0;
		horizontal = Input.GetAxisRaw("Horizontal");
	
        vertical = Input.GetAxisRaw("Vertical");
		}

        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }

    void FixedUpdate()
    {
        body2d.velocity = new Vector2(autoMove + horizontal * moveSpeed, vertical * moveSpeed);
    }
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Beam_b")
		{
			//Application.LoadLevel("Level_1");
		}
		
		if(other.tag == "Beam_g")
		{
			//Application.LoadLevel("Level_1");
		}
		
		if(other.tag == "Beam_p")
		{
			//Application.LoadLevel("Level_1");
		}
		
		if(other.tag == "Beam_r")
		{
			//Application.LoadLevel("Level_1");
		}
	}
}
