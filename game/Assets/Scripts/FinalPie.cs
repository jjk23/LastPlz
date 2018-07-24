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

    }
    private void OnCollisionEnter2D(Collision2D ohter)
    {
        if (ohter.gameObject.tag.Equals("ground"))
        {
            if (a == 0.05f)
            {
                a = -0.05f;
            }
            else 
            {
                a = 0.05f;
            }
        }
    }
}
