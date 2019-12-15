using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float force = 200;
    [SerializeField] private Transform Ez;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
       // rb.AddForce(transform.forward*force*Time.deltaTime);
        rb.velocity = transform.forward * force;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="EndZone")
        {
            this.gameObject.transform.position = Ez.transform.position;
        }
    }
}
