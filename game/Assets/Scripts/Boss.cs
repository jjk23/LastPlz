using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {
    public GameObject wood;
    public GameObject pie;
    public GameObject bed;
    float pattern;
	// Use this for initialization

    void BossAttack()
    {
        pattern = Random.Range(1, 3);
        Debug.Log(pattern);

        if (pattern == 1)
        {
            Attack1();
        }
        else if (pattern == 2)
        {
            Attack2();
        }
        else if (pattern == 3)
        {
            Attack3();
        }
    }

    //invoke

    void Start()
    {
        InvokeRepeating("BossAttack", 0, 3f);    
    }

    void Update()
    {
    }

    void Attack1()
    {
        Instantiate(wood, new Vector3(8, 0, 0), new Quaternion(0, 0, 0, 0));
    }
    void Attack2()
    {
        Instantiate(pie, new Vector3(8, -0.3f, 0), new Quaternion(0, 0, 0, 0));
    }
    void Attack3()
    {

    }
}
