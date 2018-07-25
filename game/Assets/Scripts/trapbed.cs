using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapbed : MonoBehaviour {
public float a;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0,-0.1f,0);
	}
	/// <summary>
	/// Sent when an incoming collider makes contact with this object's
	/// collider (2D physics only).
	/// </summary>
	/// <param name="other">The Collision2D data associated with this collision.</param>
}
