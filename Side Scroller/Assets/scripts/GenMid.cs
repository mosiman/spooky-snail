﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenMid : MonoBehaviour {

    //float camOriginX = -3.3428f;
    //float camOriginY = -1.5f;
    float camRightmost = 3.3428f;
    Vector3 spawnPos;

    public Transform next;
    public Transform enemy_1;
    public Transform enemy_2;
    float size;
    float nextSize;
    bool genned;

    // Use this for initialization
    void Start ()
    {
        genned = false;
        size = 0.13f;
        nextSize = 1.59f;
        spawnPos = new Vector3(3.3428f + nextSize / 2, -1.4f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (!genned && (this.transform.position.x + size / 2 - 0.15f) < camRightmost)
        {
            float choice = Random.Range(0f, 1f);
            if (choice < 0.5f)
            {
                Instantiate(enemy_1, new Vector3(spawnPos.x, -0.08419779f, 0), Quaternion.identity);

            } else
            {
                Instantiate(enemy_2, new Vector3(spawnPos.x, -0.08419779f, 0), Quaternion.identity);

            }
            Instantiate(next, spawnPos, Quaternion.identity);
            genned = true;
        }
	}
}
