using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitGetter : MonoBehaviour
{
    public GameObject a,b;
    // Start is called before the first frame update
    void Start()
    {
        a.SetActive(false);
    }
    void Update()
    {
        transform.position = b.transform.position;
        Vector3 temp = new Vector3(0, 1f, 0);
        transform.position += temp;

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hiiiii");
        if (other.tag == "enemy" )
        {
            Debug.Log("enem innn");
            a.SetActive(true);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("byeee");
        if (other.tag == "enemy")
        {

            Invoke("invokefalse", 2.0f);
        }
    }
    void invokefalse()
    {
        a.SetActive(false);
    }
}
