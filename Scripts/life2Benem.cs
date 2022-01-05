using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class life2Benem : MonoBehaviour
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
    // Start is called before the first frame update
    void Start()
    {
        
        nextL.SetActive(false);

        life = 15;
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (life <1)
        {
            die();
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.name == "wood")
        {
            AAY.Play();
            anim.SetBool("gethit", true);
            life = life - 1;
            lifebar.fillAmount = (float)life / 15;
        }

    }
    public void die()
    {
        life = 0;
        anim.SetBool("die", true);
        nextL.SetActive(true);
        death.Play();
        Destroy(gameObject, 1.5f);
    }
    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("gethit", false);
    }
}
