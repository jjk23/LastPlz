using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Springcamera : MonoBehaviour {
    Vector3 yunvec;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        yunvec = GameObject.Find("Yunjae").transform.position;
        transform.position = Vector3.Lerp(transform.position, yunvec +new Vector3(0,0,-10),0.04f);
	}
}
