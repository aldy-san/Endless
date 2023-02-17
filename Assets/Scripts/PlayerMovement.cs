using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2f;
    public float forwardSpeed = 1f;
    Rigidbody rb;
    Spawner spawner;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawner = FindObjectOfType<Spawner>();
        rb.velocity = new Vector3(0, 0, forwardSpeed);
    }
    void Update()
    {
        rb.AddForce(new Vector3(speed * Input.GetAxis("Horizontal"), 0, 0));
        transform.position += new Vector3(0, 0, 1) * forwardSpeed * Time.deltaTime;
    }
    private void FixedUpdate()
    {
        // rb.AddForce(new Vector3(0, 0, forwardSpeed));

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        spawner.Spawn();
    }
}
