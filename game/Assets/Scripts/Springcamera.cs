using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Springcamera : MonoBehaviour {
    Vector3 yunvec;
	Text life_t;
	public static int life {get; set;}
	public static int stage {get; set;}
	// Use this for initialization
	void Start () {
		life = 3;		
		GameObject.Find("a").transform.GetChild(0).gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
		life_t = GameObject.Find("Life").GetComponent<Text>();
        life_t.text = "Life : "+life;
		if(GameObject.FindWithTag("Player"))
		{
			yunvec = GameObject.FindGameObjectWithTag("Player").transform.position;
		}

        transform.position = Vector3.Lerp(transform.position, yunvec +new Vector3(0,0,-10),0.04f);
	}
}
