using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
	public GameObject Player;
	//public GameObject shield, shield_b, shield_g, shield_p, shield_r;
	public GameObject shield;
	public Sprite shield_b;
    public Sprite shield_g;
	public Sprite shield_p;
    public Sprite shield_r;
	
	private SpriteRenderer spriteRenderer;
	
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            GetComponent<SpriteRenderer>().sprite = shield_b;
        }
		if (Input.GetKeyUp(KeyCode.Keypad1))
        {
            GetComponent<SpriteRenderer>().sprite = null;
        }
		
		if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            GetComponent<SpriteRenderer>().sprite = shield_g;
        }
		if (Input.GetKeyUp(KeyCode.Keypad2))
        {
            GetComponent<SpriteRenderer>().sprite = null;
        }
		
		if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            GetComponent<SpriteRenderer>().sprite = shield_p;
        }
		if (Input.GetKeyUp(KeyCode.Keypad3))
        {
            GetComponent<SpriteRenderer>().sprite = null;
        }
		
		if (Input.GetKeyDown(KeyCode.Keypad4))
        {
           GetComponent<SpriteRenderer>().sprite = shield_r;
        }
		if (Input.GetKeyUp(KeyCode.Keypad4))
        {
            GetComponent<SpriteRenderer>().sprite = null;
        }
    }
}
