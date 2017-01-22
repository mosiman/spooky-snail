using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenLeft : MonoBehaviour {

    float camOriginX = -3.3428f;
    float camOriginY = -1.5f;
    float camRightmost = 3.3428f;
    Vector3 spawnPos;
    public Transform next;
    float size;
    float nextSize;

    public static float gap;
    bool genned = false;

    // Use this for initialization
    void Start ()
    {
        gap = Random.Range(0.5f, 1.2f);
        genned = false;
        size = 0.13f;
        nextSize = 0.13f;
        spawnPos = new Vector3(3.3428f + nextSize / 2, -1.4f, 0);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (!genned && (this.transform.position.x + size / 2 - 0.05f + gap) < camRightmost)
        {
            Instantiate(next, spawnPos, Quaternion.identity);
            genned = true;
        }

    }
}
