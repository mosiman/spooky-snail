using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy_2 : MonoBehaviour {
    public float spinZ;
    public float speedConst = 1.6f;
    Vector3 spin;

    float camOriginX = -3.3428f;
    float camOriginY = -1.5f;
    CircleCollider2D circle;
    float size;

    // Use this for initialization
    void Start()
    {
        spin = this.transform.rotation.eulerAngles;
        circle = GetComponent<CircleCollider2D>();
        size = circle.radius;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += speedConst * Vector3.left * Time.deltaTime * background.speedupConst * mainChar.slowmotion;

        spin.z += spinZ;
        this.transform.rotation = Quaternion.Euler(spin);
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
        }
    }

}