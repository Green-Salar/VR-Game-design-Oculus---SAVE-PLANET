using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform exitPoint;
    public AudioSource gunShot;
    public GameObject wood;
    private float timeElapsed = 0;

  

    public void shoot ()
    {
        GameObject tempBullet;
        tempBullet = Instantiate(wood, exitPoint.position, exitPoint.rotation) as GameObject;
        tempBullet.name = "wood";
        //tempBullet.trasform.Rotate(vector3.left*90);

        tempBullet.GetComponent<Rigidbody>().velocity = transform.up * 40;

        gunShot.Play();
        Destroy(tempBullet, 2.0f);

    }
}
