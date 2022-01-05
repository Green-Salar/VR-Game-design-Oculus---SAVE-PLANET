using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class follower : MonoBehaviour
{
    private NavMeshAgent agent;
    private Vector3 prevPos;
    public Transform destini;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = destini.position;
    }
}
