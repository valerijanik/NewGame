using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Controller : MonoBehaviour
{
    public int enemy1Health = 100;
    //public GameObject explosion;
    
    public float enemy1Damage = 3.0f;

    Rigidbody rb;
    GameObject target;
    Vector3 directionToTarget;

    [SerializeField]
    private float moveSpeed = 15;
    [SerializeField]
    private float acceleration = 2f;

    private void Start()
    {
        target = GameObject.Find("Turret");
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        moveSpeed += Time.deltaTime * acceleration;
        MoveEnemy();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Turret")
        {
            Destroy(gameObject);
        }
    }

    void MoveEnemy()
    {
        if (target != null)
        {
            directionToTarget = (target.transform.position - transform.position).normalized;
            rb.velocity = new Vector3(directionToTarget.x * moveSpeed, directionToTarget.y * moveSpeed, directionToTarget.z * moveSpeed);
        }
        else
            rb.velocity = Vector3.zero;
    }
}
