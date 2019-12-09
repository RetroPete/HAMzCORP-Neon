using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
	public GameObject Player;
	public GameObject shield;
	public GameObject shield_b;
	public GameObject shield_g;
	public GameObject shield_p;
	public GameObject shield_r;
	
    // Start is called before the first frame update
    void Start()
    {
       
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            shield_b.SetActive(true);
        }
		
		if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            shield_g.SetActive(true);
		}
		
		if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            shield_p.SetActive(true);
        }
		
		if (Input.GetKeyDown(KeyCode.Keypad4))
        {
           shield_r.SetActive(true);
        }
    }
}