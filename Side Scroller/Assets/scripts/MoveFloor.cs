using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
<<<<<<< HEAD
    public Transform enemy_1;

    public Vector3 speed = new Vector3(1,0,0);
=======

    public Vector3 speed = new Vector3(1, 0, 0);
>>>>>>> 622696af15186dfc175f6cd7f3141d6a17b1aefe
    BoxCollider2D rb;
    Vector3 worldPosition;
    Vector3 rbOffsetAndSize;
    // Use this for initialization
    void Start()
    {
        Vector3 pos = this.transform.position;
        rb = GetComponent<BoxCollider2D>();
<<<<<<< HEAD
        rbOffsetAndSize = new Vector3 (rb.offset.x + rb.size.x/2,0,0);
=======
        rbOffsetAndSize = new Vector3(rb.offset.x + rb.size.x / 2, 0, 0);
>>>>>>> 622696af15186dfc175f6cd7f3141d6a17b1aefe
        worldPosition = Camera.main.WorldToScreenPoint(new Vector3(pos.x + rbOffsetAndSize.x, pos.y, 0));
        //print("worldPos:" + worldPosition.x.ToString() + " screen-world: " + (Camera.main.ScreenToWorldPoint(worldPosition) - rbOffsetAndSize).ToString()
        //    + " position: " + this.transform.position.ToString() + " speed: " + speed.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        worldPosition.x -= speed.x;
        //print("worldPos:" + worldPosition.x.ToString() + " screen-world: " + (Camera.main.ScreenToWorldPoint(worldPosition) - rbOffsetAndSize).ToString()
        //    + " position: " + this.transform.position.ToString() + " speed: " + speed.ToString());
        this.transform.position = Camera.main.ScreenToWorldPoint(worldPosition) - rbOffsetAndSize;
        Loop();
    }

    void Loop()
    {
        if (worldPosition.x < 0)
        {
            worldPosition.x = Camera.main.pixelWidth;
            worldPosition = Camera.main.WorldToScreenPoint((Camera.main.ScreenToWorldPoint(worldPosition) + new Vector3(rb.size.x, 0, 0)));
<<<<<<< HEAD
            //Vector3 speed1 = Camera.main.WorldToScreenPoint(speed);
            Instantiate(enemy_1, new Vector3(2.471426f, -0.1496139f, 0), Quaternion.identity);
=======
>>>>>>> 622696af15186dfc175f6cd7f3141d6a17b1aefe
        }

    }
}
