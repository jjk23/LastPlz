﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouJustactivatedmytrapcard : MonoBehaviour {
GameObject trap;
	// Use this for initialization
	void Start () {
		trap = GameObject.Find("Trapcard");
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
		if(other.gameObject.tag == "Player")
		{
			trap.transform.GetChild(0).gameObject.SetActive(true);
		}
	}
}
