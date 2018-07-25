using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addspicy2 : MonoBehaviour {
	IEnumerator ZZZ()
	{
		transform.Translate(0,-0.02f,0);
		yield return new WaitForSeconds(1);
		StartCoroutine("ZZZ");
	}

	// Use this for initialization
	void Start () {
		StartCoroutine("ZZZ");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
