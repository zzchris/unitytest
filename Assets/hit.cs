﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    public GameObject hitCheck;
    public float speed = 5;
    public Vector3 dir0;
    public Vector3 dir1;
    public Vector3 dir2;
    public Vector3 dir3;
    bool flag = true;
    // Use this for initialization
    void Start()
    {
        hitCheck = GameObject.Find("Markers");
        dir0 = hitCheck.transform.GetChild(index: 0).position - transform.GetChild(index:1).localPosition;
        dir1 = hitCheck.transform.GetChild(index: 1).position - transform.GetChild(index:2).localPosition;
        dir2 = hitCheck.transform.GetChild(index: 2).position - transform.localPosition;
        dir3 = hitCheck.transform.GetChild(index: 3).position - transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        float distThisFrame = speed * Time.deltaTime;
        transform.GetChild(index:1).Translate(dir0.normalized * distThisFrame);
        transform.GetChild(index:2).Translate(dir1.normalized * distThisFrame);
        if (Input.GetKeyDown("n"))
        {
            if (transform.GetChild(index: 1).localPosition.z >= -22.1 && transform.GetChild(index: 1).localPosition.z < -21.9)
            {
                    print("hit");
                    flag = true;
                
            }
        }
        else if (transform.GetChild(index: 1).localPosition.z < -22.1 && !flag)
        {
            print("miss");
        }
        if (transform.GetChild(index: 1).localPosition.z < -22.2)
        {
            transform.GetChild(index: 1).SetPositionAndRotation(GameObject.Find("Hit").transform.GetChild(index: 0).position, GameObject.Find("Hit").transform.GetChild(index: 0).rotation);
            flag = false;
        }
        if (transform.GetChild(index: 2).localPosition.z < -22.2)
        {
            transform.GetChild(index: 2).SetPositionAndRotation(GameObject.Find("Hit").transform.GetChild(index: 0).position, GameObject.Find("Hit").transform.GetChild(index: 0).rotation);
            flag = false;
        }

    }
}

  
