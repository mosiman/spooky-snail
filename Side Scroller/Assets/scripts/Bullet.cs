using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public Vector3 speed = new Vector3(8, 0, 0);
    Vector3 relativePos;
    CapsuleCollider2D rb;

    // Use this for initialization
    void Start ()
    {
        Vector3 pos = this.transform.position;
        rb = GetComponent<CapsuleCollider2D>();
        relativePos = Camera.main.WorldToScreenPoint(new Vector3(pos.x - rb.offset.x, pos.y, 0));

    }
	
	// Update is called once per frame
	void Update () {
        relativePos.x += speed.x;
        this.transform.position = Camera.main.ScreenToWorldPoint(relativePos);
	}
}
