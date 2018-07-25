using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPie : MonoBehaviour
{
    public float a;
    // Use this for initialization
    void Start()
    {
        a = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, a, 0, Space.World);
        transform.Rotate(new Vector3(0, 0, 1));
        if (transform.position.y < -1.5)
        {
            a = 0.05f;
        }
        else if (transform.position.y > 1.5)
        {
            a = -0.05f;
        }
    }
}
