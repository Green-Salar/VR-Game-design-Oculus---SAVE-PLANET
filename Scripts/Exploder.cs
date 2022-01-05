using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
    public GameObject destroyedV;

    public void destroy()
    {
        Instantiate(destroyedV, transform.position, transform.rotation);
        Destroy(gameObject);

    }
}
