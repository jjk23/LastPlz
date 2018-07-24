using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Python : MonoBehaviour {
    public float a;
    // Use this for initialization
    void Start () {
        a = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(a, 0, 0, Space.World);
        transform.Rotate(new Vector3(0, 0, 1));
        
	}
    private void OnCollisionEnter2D(Collision2D ohter)
    {
        if(ohter.gameObject.tag.Equals("ground"))
        {
            if(a == 0.1f)
            {
                a = -0.1f;
            }
            else
            {
                a = 0.1f;
            }
        }
    }
}
