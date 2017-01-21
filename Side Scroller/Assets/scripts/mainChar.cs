using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainChar : MonoBehaviour {
    
    double g = -9.8;
    Vector3 startPos;
    public float jumpVel = 5000f;
    public Rigidbody2D rb;
    public bool isJumping; //auto set to false
    public Animator charRun;
    public Animator charJump;
    

    // Use this for initialization
    void Start()
    {
        print("hello from char script!");
        rb = this.GetComponent<Rigidbody2D>();
        isJumping = false;
    }
        // Update is called once per frame
    void Update ()
    {
        // Pressed 'W', jump
	    if (Input.GetKeyDown(KeyCode.W)){
            if (isJumping == false)
            {
                isJumping = true;
                print("jump!");
                rb.AddForce(transform.up * jumpVel);
            }
    
        }
	}
    void FixedUpdate()
    {

    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        isJumping = false;
    }
}
