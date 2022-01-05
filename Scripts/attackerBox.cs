using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackerBox : MonoBehaviour
{
    public GameObject player;
    private Vector3 between;
    private Rigidbody rb;
    public AudioSource explosionaudio;
    public GameObject nextBox;
    public GameObject destroyedV;


    public float Acceleration = 45.0f;
    public float Deceleration = 20.0f;
    public float MaxSpeed = 360.0f;

    float m_CurrentSpeed;




    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerPose");
        rb = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        m_CurrentSpeed = Mathf.Min(m_CurrentSpeed + Acceleration * Time.deltaTime, MaxSpeed);
        if (m_CurrentSpeed > 0.001f)
        {
            transform.Rotate(new Vector3(0, 0, m_CurrentSpeed * Time.deltaTime));
        }

        between = player.transform.position - transform.position;
        rb.velocity = between * 2f;
        
    }

    public void destroyer()
    {
        explosionaudio.Play();
        Instantiate(destroyedV, transform.position, transform.rotation);
        Collider[] collidersmove = Physics.OverlapSphere(transform.position, .6f);
        foreach (Collider nearbyObject in collidersmove)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(1f, transform.position, 0.6f);
            }

        }
        nextBox.SetActive(true);
        Destroy(gameObject);

    }

   

    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.name == "Player" || other.transform.name == "wood")
        {
            destroyer();
        }

    }
}
