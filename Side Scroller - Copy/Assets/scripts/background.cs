using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///   - Add enemies spawn + despawn
///   - Enemies in arrayz of GameObjectz
/// </summary>
/// 


public class background : MonoBehaviour {

    //public Transform enemy_1;

    public static float clock;
    public static float speedupConst;
    //public float floorSpawn;
    //public Transform floor;
    //public Vector3 floorSpawnPos;

    // Use this for initialization
    void Start () {
        speedupConst = 1.0f;
        clock = 0;
        /*floorSpawn = 1.15f;
        floorSpawnPos = new Vector3 (3.3428f + 1.83779f/ 2, -1.4f, 0);
        */
    }
	
	// Update is called once per frame
	void Update () {
        clock += 0.01f;
        if (clock- 0.001f >= 2 && speedupConst <= 2.5)
        {
            speedupConst += 0.1f;
            clock = 0;
            print(speedupConst + " Bee");
        }
        /*if (clock % floorSpawn <= 0.01)
        {
            Instantiate(floor, floorSpawnPos, Quaternion.identity);

            clock = 0.1f;
        }*/
	}
}
