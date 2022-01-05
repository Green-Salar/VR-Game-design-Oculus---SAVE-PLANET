using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stepSound : MonoBehaviour
{
    public AudioSource step;
    private Vector3 loc1, loc2;
    private float dt, i, t1, t2;
    // Start is called before the first frame update
    void Start()
    {
        t1 = Time.time;
        loc1 = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        t2 = Time.time;
        dt = t2 - t1;
        loc2 = transform.position;
        if ((loc2 - loc1).magnitude > .1)
        {
            step.Play();
            loc1 = loc2;
            t1 = t2;
            i = 1;
        }
        if (i==1 && dt > 1 && (loc2 - loc1).magnitude < .1)
        {
            step.Pause();
            i = 0;
            t1 = t2;
            loc1 = loc2;
        }

    }
}
