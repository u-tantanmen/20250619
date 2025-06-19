using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class shooter : MonoBehaviour
{
    public GameObject candy;
    public GameObject gutitubo;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            CandyPop();
        }
    }
    public void CandyPop()
    {
        GameObject candyPrefab = Instantiate(candy, transform);
         candyPrefab.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
    }
}
