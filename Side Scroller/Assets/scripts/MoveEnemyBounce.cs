using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyBounce : MonoBehaviour {



    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        this.transform.position = new Vector3 (this.transform.position.x + 5, 0, 0);
        DeleteInstance();
    }

    void RandomSpawn(float min, float max)
    {
        
    }

    void DeleteInstance()
    {
        Vector3 position = Camera.main.WorldToScreenPoint(this.transform.position);
        print(position);
        if (position.x < 0 || position.y < 0)
        {
            Destroy(gameObject);
        }
    }
}
