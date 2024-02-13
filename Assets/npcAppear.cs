using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcAppear : MonoBehaviour
{
    public Collider coll;

    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
