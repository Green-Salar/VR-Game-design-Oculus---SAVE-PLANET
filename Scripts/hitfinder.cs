using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitfinder : MonoBehaviour
{
    private GameObject player;
    private float dist;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        dist = Mathf.Abs(transform.position.x - player.transform.position.x) + Mathf.Abs(transform.position.z - player.transform.position.z);
        //Debug.Log(dist);
        if (dist < 0.3) { 
            Debug.Log("hitteted");
            player.SendMessage("hit");
        }
    }
}
