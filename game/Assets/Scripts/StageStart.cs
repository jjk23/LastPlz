using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageStart : MonoBehaviour {
    public GameObject Player;

	// Use this for initialization
	void Start () {
        GameObject.Instantiate(Player, new Vector3(0, 0, 0), new Quaternion());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
