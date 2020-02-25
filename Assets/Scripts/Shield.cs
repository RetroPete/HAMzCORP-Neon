using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
	public GameObject player;
	public GameObject shield;
	public GameObject shield_b;
	public GameObject shield_g;
	public GameObject shield_p;
	public GameObject shield_r;
	
    // Start is called before the first frame update
    void Start()
    {
		shield.gameObject.SetActive(true);
		shield_b.gameObject.SetActive(false);
		shield_g.gameObject.SetActive(false);
		shield_p.gameObject.SetActive(false);
		shield_r.gameObject.SetActive(false);
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            shield_b.gameObject.SetActive(true);
        }
		if (Input.GetKeyUp(KeyCode.Keypad1))
		{
            shield_b.gameObject.SetActive(false);
        }
		
		
		if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            shield_g.gameObject.SetActive(true);
		}
		if (Input.GetKeyUp(KeyCode.Keypad2))
		{
            shield_g.gameObject.SetActive(false);
        }
		
		
		if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            shield_p.gameObject.SetActive(true);
        }
		if (Input.GetKeyUp(KeyCode.Keypad3))
		{
            shield_p.gameObject.SetActive(false);
        }
		
		
		if (Input.GetKeyDown(KeyCode.Keypad4))
        {
           shield_r.gameObject.SetActive(true);
        }
		if (Input.GetKeyUp(KeyCode.Keypad4))
		{
            shield_r.gameObject.SetActive(false);
        }
    }
}