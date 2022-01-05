using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setFalse : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;
    // Start is called before the first frame update
    void Start()
    {
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
