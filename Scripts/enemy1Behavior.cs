using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class enemy1Behavior : MonoBehaviour
{
    private Animator anim;
    private CharacterController controller;
    private NavMeshAgent agent;
    private Transform enemyTransform;
    private GameObject enemyObject;
    private bool attacking;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        enemyObject = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        anim.SetBool("run", (((agent.velocity.magnitude / agent.speed) > 0.01) && agent.remainingDistance > 0.1));

        if (enemyObject != null && attacking == true && (enemyTransform.position - agent.transform.position).magnitude < 3)
        {
            anim.SetBool("attacking", true);
            agent.transform.LookAt(enemyTransform.position);
        }
        else
        {
            anim.SetBool("attacking", false);
        }

        enemyTransform = enemyObject.transform;

        //hit.lifeScript.life = 1;
        //Debug.Log(hit.collider.gameObject); 
        Vector3 between = agent.transform.position - enemyTransform.position;
        attacking = true;
        if ((between.magnitude) > 2)
        {
            //anim.SetBool("run", false);
            agent.destination = between.normalized * 2f + enemyTransform.position;

        }


    } 
}
