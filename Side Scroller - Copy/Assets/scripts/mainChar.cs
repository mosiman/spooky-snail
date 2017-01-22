using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainChar : MonoBehaviour {
    
    //double g = -9.8;
    Vector3 startPos;
    public float jumpVel = 5000f;
    public Rigidbody2D rb;
    public bool isJumping; //auto set to false
    public RuntimeAnimatorController charRun;
    public RuntimeAnimatorController charJump;
    public Animator charAnim;
    public BoxCollider2D boxcol;

    public Vector2 jumpSize;
    public Vector2 runSize;

    public int interval = 55;
    public int cooldown;
    int ammo;
    public Transform pellet;
    Vector3 diff= new Vector3 (0.31f, 0.075f, 0);

    public static float slowmotion;
    public int slowCD;

    // Use this for initialization
    void Start()
    {
        cooldown = 0;
        ammo = 3;
        slowmotion = 1;
        slowCD = 0;
        print("hello from char script!");
        rb = this.GetComponent<Rigidbody2D>();
        charAnim = gameObject.GetComponent<Animator>();
        charAnim.runtimeAnimatorController = charRun;
        isJumping = false;
        boxcol = gameObject.GetComponent<BoxCollider2D>();

        // Hardcoded!!!!! boxCollider2D sizes for jump and run animations
        jumpSize = new Vector2(0.16f,0.16f);
        runSize = new Vector2(0.38f, 0.43f);

        boxcol.size = runSize;

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
                charAnim.runtimeAnimatorController = charJump;
                boxcol.size = jumpSize;
            }
        }

        // Shoot with leftclick
        if (Input.GetMouseButtonDown(0))
        {
            if (ammo > 0)
            {
                ammo--;
                Instantiate(pellet, this.transform.position + diff, Quaternion.identity);
            }
        }
        // Slow down with 'space'
        if (Input.GetKeyDown(KeyCode.Space) && slowCD <= 300)
        {
            slowmotion = 0.5f;
        } else if (Input.GetKeyUp(KeyCode.Space) || slowCD >= 300)
        {
            slowmotion = 1.0f;
            print(slowCD);
        }

        if (slowmotion == 0.5f)
        {
            slowCD += 2;
        } else
        {
            slowCD -= 1;
        }
	}
    void FixedUpdate()
    {
        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        isJumping = false;
        charAnim.runtimeAnimatorController = charRun;
        boxcol.size = runSize;
    }
}
