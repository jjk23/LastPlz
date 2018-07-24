using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class specialwood : MonoBehaviour {
	int a=-90;
	float b=-0.2f;
	int c=0;
IEnumerator WoodSwordmove()
{
	transform.Rotate(0,0,a);
	transform.Translate (new Vector3(b,0,0),Space.World);
	yield return new WaitForSeconds(0.2f);
	if(a == -90)
	a=90;
	else
	a=-90;
	StartCoroutine("WoodSwordmove");
}
	// Use this for initialization
	void Start () {
		StartCoroutine("WoodSwordmove");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	/// <summary>
	/// Sent when an incoming collider makes contact with this object's
	/// collider (2D physics only).
	/// </summary>
	/// <param name="other">The Collision2D data associated with this collision.</param>
	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "ground")
		{
			if(b==-0.2f)
			b=0.2f;
			else
			b=-0.2f;

			transform.Rotate(0,0,-180);
			
		}
		
	}
}
