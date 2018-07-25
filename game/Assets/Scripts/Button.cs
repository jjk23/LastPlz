using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public void Button1()
    {
        SceneManager.LoadScene("stage1");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
