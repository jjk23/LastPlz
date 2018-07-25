using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPie : MonoBehaviour
{
    public float a;
    // Use this for initialization
    void Start()
    {
        a = -0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(a, 0, 0, Space.World);
        transform.Rotate(new Vector3(0, 0, 1));

    }
}
