using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObj : MonoBehaviour {

    public GameObject prefab;


    float camOriginX = -3.3428f;
    float camOriginY = -1.5f;
    float camRightmost = 3.3428f;

    public float speedConst = 1.5f;
    public bool wantWrapAround;
    public float wraparoundPosition;
    public float size;

    BoxCollider2D box;
    Renderer rend;

    Vector3 startPos;

	// Use this for initialization
	void Start () {
        // Instantiate(prefab, new Vector3(camOriginX, camOriginY, 0), Quaternion.identity);

        if(wraparoundPosition == 0)
        {
            wraparoundPosition = camRightmost;
        }
        rend = GetComponent<Renderer>();
        box = GetComponent<BoxCollider2D>();
        //print(rend.bounds.size.x);
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.left * Time.deltaTime*speedConst*background.speedupConst*mainChar.slowmotion);

        if((this.transform.position.x + size/2)< camOriginX)
        {
            if (wantWrapAround)
            {
                this.transform.position = new Vector3(camRightmost + size/2, this.transform.position.y, 0);
                print("wraparound!");
                print(this.transform.position);

            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
