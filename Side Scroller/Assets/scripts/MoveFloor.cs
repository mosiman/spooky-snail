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
        //print(Camera.main.WorldToScreenPoint(Input.mousePosition).ToString());
        //print((this.GetComponent<ImagePosition>().bounds.size.x / 2).ToString());
        this.transform.position = pos;
        //print(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        //Loop();
    }

 //   void Loop()
 //   {
 //       BoxCollider2D rb = GetComponent<BoxCollider2D>();
 //   //    Vector3 worldPosition = Camera.main.WorldToScreenPoint(new Vector3(this.transform.position));
 //       print("boxCollider:" + (rb.size.x/2).ToString());
 //       print("worldPos:" + worldPosition.x.ToString());
 //       //print((worldPosition.x + rb.size.x).ToString());
 //       //print((rb.size.x).ToString());
 //       worldPosition.z = 0;
 //       //Debug.Log ("World Position: " + worldPosition.ToString());
 //       if (pos.x < 0)
 //       {
 ////           pos.x += Camera.main.pixelWidth;
 //       }
 //  //     this.transform.position = worldPosition;

 //   }
}
