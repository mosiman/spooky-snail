using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

<<<<<<< HEAD
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
=======
    public Vector3 speed = new Vector3(8, 0, 0);
    Vector3 relativePos;
    CapsuleCollider2D rb;
    Vector3 pos;

    // Use this for initialization
    void Start ()
    {
        pos = this.transform.position;
        rb = GetComponent<CapsuleCollider2D>();
        relativePos = Camera.main.WorldToScreenPoint(new Vector3(pos.x - rb.offset.x, pos.y, 0));

    }
	
	// Update is called once per frame
	void Update () {
        pos = this.transform.position;
        relativePos.x += speed.x;
        this.transform.position = Camera.main.ScreenToWorldPoint(relativePos);
        if (pos.x > 3.35)
        {
            Destroy(gameObject);
        }
>>>>>>> 622696af15186dfc175f6cd7f3141d6a17b1aefe
	}
}
