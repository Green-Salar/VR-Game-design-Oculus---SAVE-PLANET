using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class offLinkAnimations : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {

       // agent.autoTraverseOffMeshLink = false;

    }

    // Update is called once per frame
    void Update()
    {
        var agent = GetComponent<NavMeshAgent>();

        if (agent.isOnOffMeshLink)
            {
            anim.SetBool("fly", true); //Do what you want I use a function : NormalSpeed()
            }
       
            ///OffMeshLinkData data = agent.currentOffMeshLinkData;

        //calculate the final point of the link
        ///Vector3 endPos = data.endPos + Vector3.up * agent.baseOffset;

        //Move the agent to the end point
        ///agent.transform.position = Vector3.MoveTowards(agent.transform.position, endPos, agent.speed * Time.deltaTime);

        //when the agent reach the end point you should tell it, and the agent will "exit" the link and work normally after that
        ///if (agent.transform.position == endPos)
        ///{
          ///  agent.CompleteOffMeshLink();
        ///}

    }
}
