using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenRight : MonoBehaviour
{

    float camOriginX = -3.3428f;
    float camOriginY = -1.5f;
    float camRightmost = 3.3428f;
    Vector3 spawnPos;
    public Transform next;
    float size;
    float nextSize;

    public static int len;
    bool genned = false;

    // Use this for initialization
    void Start ()
    {
        len = Random.Range(1, 3);
        size = 1.59f;
        nextSize = 0.13f;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if ((this.transform.position.x + size/2 - 0.03f) < camRightmost && !genned)
        {
            if (len != 2)
            {
                spawnPos = new Vector3(3.3428f + size / 2, -1.4f, 0);
                Instantiate(this, spawnPos, Quaternion.identity);
                genned = true;
            }
            else
            {
                spawnPos = new Vector3(3.3428f + nextSize / 2, -1.4f, 0);
                Instantiate(next, spawnPos, Quaternion.identity);
                genned = true;
            }
        }
    }
}
