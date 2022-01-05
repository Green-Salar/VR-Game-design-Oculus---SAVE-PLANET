using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class offers : MonoBehaviour
{
    private Animator anim;
    private NavMeshAgent agent;
    private GameObject Cube ;
    // Start is called before the first frame update
    void Start()
    {
        Cube = GameObject.Find("Cube");
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (agent.isOnOffMeshLink)
        {
            Debug.Log("oowwwwwww");
            anim.SetBool("fly", true); 
        }
        else
        {
            anim.SetBool("fly", false);
        }


        if (Input.GetKeyDown("f"))

            Cube.SetActive(false);
        if (Input.GetKeyDown("t"))

            Cube.SetActive(true);

    }
}
