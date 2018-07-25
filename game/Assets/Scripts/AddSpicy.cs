using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSpicy : MonoBehaviour {	
public float j;
public float ac;
IEnumerator ZZZ()
	{
		transform.Translate(0,-0.02f,0);
		yield return new WaitForSeconds(1);
		StartCoroutine("ZZZ");
	}
IEnumerator accel()
{
	ac+=0.01f;
	yield return new WaitForSeconds(4.2f);
	StartCoroutine("accel");
}

    void Start()
    {
        j= 0.5f;
		StartCoroutine("accel");
		StartCoroutine("ZZZ");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(j, 0, 0, Space.World);
        transform.Rotate(new Vector3(0, 0,ac*100));
        if (transform.position.x < -3)
        {
            j = 0.05f+ac;
			
        }
        else if (transform.position.x > 7)
        {
            j = -0.05f-ac;
        }
	}
}
