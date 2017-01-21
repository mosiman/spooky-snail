using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{

    public float speed = 1f;
    Vector3 pos;

    // Use this for initialization
    void Start()
    {
        pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        pos.x -= speed;
        this.transform.position = pos;
        //print(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        Loop();
    }

    void Loop()
    {

        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(this.transform.position);
        print(worldPosition.ToString());
        worldPosition.z = 0;
        //Debug.Log ("World Position: " + worldPosition.ToString());
        if (pos.x < 0)
        {
 //           pos.x += Camera.main.pixelWidth;
        }
   //     this.transform.position = worldPosition;

    }
}
