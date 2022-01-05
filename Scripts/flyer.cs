using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyer : MonoBehaviour
{

      public GameObject playerController;
    //public Audiosource audiosource;
    private Vector3 moveDir;
    private bool isFlying;
    private bool isFalling;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
         rb = playerController.GetComponent<Rigidbody>();
        // rb.useGravity = false;
        //rb.velocity = transform.up * 80;
       // playerGravity = playerController.GetComponent<playerGravity>();
    }

    public void FlyingCheck(float gripAmount)
    {
        if (gripAmount > 0.1f)
        {
            rb.velocity = transform.up * 5;
            //DoJet(gripAmount);
            isFlying = true;
           // if (!audioSource.isPlaying)
          //  {
                //audioSource.pitch = Time.timsScale;
           //     audioSource.Play();

           // }
        }
        else if (isFlying)
        {
            StopJet();
            isFlying = false;
        }
    }

    public void DoJet(float buttonForce)
    {
        rb.useGravity = false;
        
       
    }

    public void StopJet()
    {
        rb.velocity = transform.up * 0;
        rb.useGravity = false;
       // if (audioSource.isPlaying) { audioSource.Stop(); }
    }
    // Update is called once per frame

    public void jump()
    {
       //rb.useGravity = false;
        rb.velocity = transform.up * 1f;
    }
    public void stop()
    {

        rb.velocity = transform.up * 0;
    }
}
