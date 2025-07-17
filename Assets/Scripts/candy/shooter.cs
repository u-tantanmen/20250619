using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class shooter : MonoBehaviour
{
    public GameObject pikutohausu;
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
        GameObject candyPrefab = null;
        int rnd = Random.Range(1, 3);
        if(rnd == 1)
        {
            candyPrefab = Instantiate(gutitubo,transform);
        }
        else if(rnd == 2)
        {
            candyPrefab = Instantiate(pikutohausu,transform);
        }
         candyPrefab.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
    }
}
