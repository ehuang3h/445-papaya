using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public float speed;

    private float dist;
    public float followRadius;
    
    private Boolean follow = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (follow)
        {
            dist = Vector3.Distance(transform.position, player.transform.position);
            if (dist > followRadius)
            {
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    //            Debug.Log("Following.");
            }
  //          else Debug.Log("Max distance reached. Dist: " +dist);
        }
//        else Debug.Log("Not following.");
    }

    public void startFollowing()
    {
        follow = true;
    }

    public void stopFollowing()
    {
        follow = false;
    }
}
