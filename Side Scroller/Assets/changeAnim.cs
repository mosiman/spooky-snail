using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeAnim : MonoBehaviour {

    public RuntimeAnimatorController anim1;
    public RuntimeAnimatorController anim2;

    Animator charAnim;
	// Use this for initialization
	void Start () {
        charAnim = gameObject.GetComponent<Animator>();
        charAnim.runtimeAnimatorController = anim1;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            charAnim.runtimeAnimatorController = anim2;
        }
    }
}
