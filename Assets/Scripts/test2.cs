using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{
	public GameObject Player;
	public GameObject shield;
	public GameObject shield_b;
	public GameObject shield_g;
	public GameObject shield_p;
	public GameObject shield_r;
	
	int whichShieldIsOn = 1;
	
    // Start is called before the first frame update
    void Start()
    {
       shield.gameObject.SetActive(true);
	   shield_b.gameObject.SetActive(false);
	   shield_g.gameObject.SetActive(false);
	   shield_p.gameObject.SetActive(false);
	   shield_r.gameObject.SetActive(false);
	}

	public void SwitchShield()
	{
		switch (whichShieldIsOn)
		{

			case 1:
			
				whichShieldIsOn = 5;
			
				shield.gameObject.SetActive(false);
				shield_b.gameObject.SetActive(false);
				shield_g.gameObject.SetActive(false);
				shield_p.gameObject.SetActive(false);
				shield_r.gameObject.SetActive(true);
				break;
			
			case 2:
			
				whichShieldIsOn = 4;
			
				shield.gameObject.SetActive(false);
				shield_b.gameObject.SetActive(false);
				shield_g.gameObject.SetActive(false);
				shield_p.gameObject.SetActive(true);
				shield_r.gameObject.SetActive(false);
				break;
			
			case 3:
			
				whichShieldIsOn = 3;
			
				shield.gameObject.SetActive(false);
				shield_b.gameObject.SetActive(false);
				shield_g.gameObject.SetActive(true);
				shield_p.gameObject.SetActive(false);
				shield_r.gameObject.SetActive(false);
				break;
			
			case 4:
			
				whichShieldIsOn = 2;
			
				shield.gameObject.SetActive(false);
				shield_b.gameObject.SetActive(true);
				shield_g.gameObject.SetActive(false);
				shield_p.gameObject.SetActive(false);
				shield_r.gameObject.SetActive(false);
				break;
				
			case 5:
			
				whichShieldIsOn = 1;
			
				shield.gameObject.SetActive(true);
				shield_b.gameObject.SetActive(false);
				shield_g.gameObject.SetActive(false);
				shield_p.gameObject.SetActive(false);
				shield_r.gameObject.SetActive(false);
				break;	
		}
	}
}