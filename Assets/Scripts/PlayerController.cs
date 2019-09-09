using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body2d;

    float horizontal;
    float vertical;

    public float moveSpeed;
    public float xMin, xMax, yMin, yMax;

    // Start is called before the first frame update
    void Start()
    {
        body2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        //create boundries
        body2d.position = new Vector2(
            Mathf.Clamp(body2d.position.x, xMin, xMax),
            Mathf.Clamp(body2d.position.y, yMin, yMax));
    }

    void FixedUpdate()
    {
        body2d.velocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);
    }
}
