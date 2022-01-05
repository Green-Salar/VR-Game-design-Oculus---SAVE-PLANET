using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class lifeSpider : MonoBehaviour
{
    private Animator anim; 
    private CharacterController controller;
    private NavMeshAgent agent;
    private Vector3 prevPos;
    public float life;
    public Image lifebar;
    public AudioSource AAY, death;
    // Start is called before the first frame update
    public GameObject nextL;
    void Start()
    {
        
        life = 5;
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (life == 0)
        {
            die();
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.name == "wood")
        {
            AAY.Play();
            anim.SetBool("Hit", true);
            life = life - 1;
            lifebar.fillAmount = (float)life / 5;
        }

    }
    public void die()
    {
        nextL.SetActive(true);
        life = 0;
        anim.SetBool("IsDead", true);
        death.Play();
        Destroy(gameObject, 1.5f);
    }
    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("Hit", false);
    }
}