using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainChar : MonoBehaviour {
    
    double g = -9.8;
    Vector3 startPos;
    public float jumpVel = 5f;


	// Use this for initialization
	void Start () {
        print("hello from char script!");
		
	}
	
	// Update is called once per frame
	void Update () {
        // Pressed 'W', jump
	    if (Input.GetKeyDown(KeyCode.W)){
                Jump();
                print("jump!");
        }

	}

    void Jump() {
        print(this.transform.position);
        this.GetComponent<Rigidbody2D>().addForce(jumpVel * Vector3.up);

    }
}
