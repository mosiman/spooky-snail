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


    public int interval = 55;
    public int cooldown;
    public int ammo;
    public Transform pellet;
    Vector3 diff= new Vector3 (0.31f, 0.075f, 0);


    // Use this for initialization
    void Start()
    {
        cooldown = 0;
        ammo = 3;
        print("hello from char script!");
        rb = this.GetComponent<Rigidbody2D>();
        isJumping = false;
    }
        // Update is called once per frame
    void Update ()
    {
        // Recharge ammo
        if (cooldown != interval && ammo <= 2)
        {
            cooldown++;
        } else if (cooldown == interval && ammo == 0)
        {
            ammo = 3;
            cooldown = 0;
        }

        // Pressed 'W', jump
        if (Input.GetKeyDown(KeyCode.W)){
            if (isJumping == false)
            {
                isJumping = true;
                print("jump!");
                rb.AddForce(transform.up * jumpVel);
            }
        }

        // Shoot with 'Space'
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ammo > 0)
            {
                ammo--;
                Instantiate(pellet, this.transform.position + diff, Quaternion.identity);
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
