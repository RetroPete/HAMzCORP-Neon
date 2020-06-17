using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public GameObject player;
	public GameObject booster;
	
    // Use this for initialization
    void Start()
    {
		booster.gameObject.SetActive(false);
		
	}

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.D))
        {
			booster.gameObject.SetActive(true);
        }
		if (Input.GetKeyUp(KeyCode.D))
		{
            booster.gameObject.SetActive(false);
        }
    }
}