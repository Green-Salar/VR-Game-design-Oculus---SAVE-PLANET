using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positioningRef : MonoBehaviour
{
    public Transform cameraRig;

    public Transform cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((Vector3.Distance(cameraRig.position,cube.position))>0.3)
        cameraRig.position = cube.position;

        
    }
}
