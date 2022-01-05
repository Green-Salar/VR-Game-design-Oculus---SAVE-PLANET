using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;





public class enemyBehavior : MonoBehaviour
{
    
    private Animator anim;
    private CharacterController controller;
    private NavMeshAgent agent;
    private Vector3 prevPos;
    private float life;
    private GameObject nextLevel;
   
    // Start is called before the first frame update
    void Start()
    {
       // nextLevel = GameObject.Find("level2");
        //nextLevel.SetActive(false);
        life = 1;
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (life == 0)
        {
            anim.SetBool("die", true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger entered");
        if(other.transform.name == "SWORD")
        {
            anim.SetBool("gethit" , true);
            life = life - 1;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        
            anim.SetBool("gethit", false);

      
    }
}
