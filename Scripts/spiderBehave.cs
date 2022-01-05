using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class spiderBehave : MonoBehaviour
{
    private Animator anim;
    private CharacterController controller;
    private NavMeshAgent agent;
    private Transform enemyTransform;
    private GameObject enemyObject;
    private bool attacking;
    public AudioSource attackSound;
    public AudioSource poisonShotSound;
    float dt,i;

    public Transform exitPoint;
    public GameObject webSoot;

    public void shootweb()
    {
        GameObject tempBullet;
        tempBullet = Instantiate(webSoot, exitPoint.position, exitPoint.rotation) as GameObject;
        tempBullet.tag = "enemy";
        tempBullet.GetComponent<Rigidbody>().velocity = transform.forward * 10;
        poisonShotSound.Play();
        Destroy(tempBullet, 2.0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();

        enemyObject = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        dt += Time.deltaTime; 
        if (dt > 1 && i==1)
        {
            i = 2;

        }

        if (enemyObject != null)
        {
            enemyTransform = enemyObject.transform;
            agent.transform.LookAt(enemyTransform.position);
            anim.SetBool("IsMoving", (((agent.velocity.magnitude / agent.speed) > 0.01) && agent.remainingDistance > 0.1));
            float dist = (enemyTransform.position - agent.transform.position).magnitude;
            if (enemyObject != null && attacking == true)
            {
                anim.SetBool("Attack", true);
                if (dist < 15  && dt > 1)
                {
                    
                    if (dist < 4 )
                    {
                        dt = 0;
                        
                        attackSound.Play();
                    }
                    else
                    {
                        dt = 0;
                        shootweb();
                    }
                }
               

            }
            else
            {
                anim.SetBool("Attack", false);
            }



            //hit.lifeScript.life = 1;
            //Debug.Log(hit.collider.gameObject); 

            Vector3 between = agent.transform.position - enemyTransform.position;
            attacking = true;
            if ((between.magnitude) > 3)
            {
                //anim.SetBool("run", false);
                agent.destination = between.normalized * 3f + enemyTransform.position;

            }
        }
        else
        {
            anim.SetBool("Attack", false);
            agent.destination = agent.transform.position;
        }


    }
}
