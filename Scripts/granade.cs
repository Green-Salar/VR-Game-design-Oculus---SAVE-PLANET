using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class granade : MonoBehaviour
{
    public float delay = 5f;
    public float radius = 10f;
    public float force = 1f;
    public GameObject explosionEffect;
    public AudioSource audioexplode;
    private float countdown = 7;
    bool hasExploded = false;
    float i = 1;
    // Start is called before the first frame update
    


    // Update is called once per frame
    void Update()
    {
        if (i == 2)
        {
            countdown -= Time.deltaTime;
        }
        
        if (i==1&&countdown < 2f)
        {
            i = 2;
            //audioexplode.Play();
        }
        if(countdown<= 0f && !hasExploded)
        {
            audioexplode.Play();
            Expload();
            hasExploded = true;
        }
    }

    public void triggerIt()
    {
        i = 2;
        countdown = delay;
    }

    public void Expload()
    {
        
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Collider[] colliders=  Physics.OverlapSphere(transform.position,radius); 

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();

            life2Benem dier = nearbyObject.GetComponent<life2Benem>();
            if (dier != null)
            {
                dier.die();
            }
            lifeSpider dierr = nearbyObject.GetComponent<lifeSpider>();
            if (dierr != null)
            {
                dierr.die();
            }
            Exploding des = nearbyObject.GetComponent<Exploding>();
            if (des != null)
            {
                des.destroyer();
            }
        }
        Collider[] collidersmove = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider nearbyObject in collidersmove)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radius);
            }

        }
        Destroy(gameObject);
    }
}
