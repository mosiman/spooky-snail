﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    float camOriginX = -3.3428f;
    float camOriginY = -1.5f;
    float camRightmost = 3.3428f;

    CircleCollider2D circle;
    float size;
    public float speedConst = 1.5f;
    // Use this for initialization
    void Start () {
        circle = GetComponent<CircleCollider2D>();
        size = circle.radius;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.left * Time.deltaTime * speedConst);

        if ((this.transform.position.x + size) < camOriginX || this.transform.position.y + size < camOriginY)
        {
                Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.transform.gameObject.name == "Pellet(Clone)")
        {
            Destroy(coll.transform.gameObject);
            Destroy(gameObject);
        }
    }
}
