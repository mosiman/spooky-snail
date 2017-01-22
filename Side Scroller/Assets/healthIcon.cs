using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthIcon : MonoBehaviour {

    public int myHealth;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (mainChar.health < myHealth)
        {
            Destroy(gameObject);
        }
	}
}
