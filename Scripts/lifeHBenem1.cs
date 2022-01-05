using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class lifeHBenem1 : MonoBehaviour
{
    private Animator anim;
    private CharacterController controller;
    private NavMeshAgent agent;
    private Vector3 prevPos;
    private float life,a;
    public Image lifebar;
    private GameObject nextL;
    public AudioSource AAY, death, end,hello;
    // Start is called before the first frame update
    void Start()
    {
        a = 0;
        
        nextL = GameObject.Find("FINISH");
        nextL.SetActive(false);
        life = 10;
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (a == 0) { hello.Play(); a = 1; }
 
        if (life == 0)
        {
            nextL.SetActive(true);
            end.Play();
            death.Play();
            //  anim.SetBool("die", true);
            
            Destroy(gameObject,0.5f);
        }

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.name == "wood")
        {
            AAY.Play();
          //  anim.SetBool("gethit", true);
            life = life - 1;
            lifebar.fillAmount = (float)life / 10;
        }

    }
    private void OnTriggerExit(Collider other)
    {
       // anim.SetBool("gethit", false);
    }
}
