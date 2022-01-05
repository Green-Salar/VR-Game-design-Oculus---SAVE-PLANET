using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startBoxAttack : MonoBehaviour
{
    public GameObject boxAttackers;
    public GameObject oculus;
    private Vector3 oculusPose;
    // Start is called before the first frame update
    void Start()
    {
        oculusPose = oculus.transform.position;
        boxAttackers.SetActive(false);
    }
    void Update()
    {
        if(oculus.transform.position != oculusPose) boxAttackers.SetActive(true);
    }
}
