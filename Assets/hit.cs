using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    public GameObject hitCheck;
    public float speed = 5;
    public Vector3 dir;
    bool flag = true;
    // Use this for initialization
    void Start()
    {
        hitCheck = GameObject.Find("Markers");
        dir = hitCheck.transform.GetChild(index: 2).position - transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        float distThisFrame = speed * Time.deltaTime;
        transform.Translate(dir.normalized * distThisFrame);
        if (Input.GetKeyDown("n"))
        {
            if (transform.localPosition.z >= -22.1 && transform.localPosition.z < -21.9)
            {
                    print("hit");
                    flag = true;
                
            }
        }
        else if (transform.localPosition.z < -22.1 && !flag)
        {
            print("miss");
        }
        if (transform.localPosition.z < -22.2)
        {
            transform.SetPositionAndRotation(GameObject.Find("Hit").transform.GetChild(index: 1).position, GameObject.Find("Hit").transform.GetChild(index: 1).rotation);
            flag = false;
        }
        
    }
}

  
