using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int enemyHealth = 100;
    //public GameObject explosion;

    [SerializeField]
    private int _enemyDamage = 5;

    Rigidbody rb;
    GameObject target;
    float moveSpeed;
    Vector3 directionToTarget;

    private void Start()
    {
        target = GameObject.Find("Turret");
        rb = GetComponent<Rigidbody>();
        moveSpeed = Random.Range(100f, 300f);
    }

    private void Update()
    {
        MoveEnemy();
    }

    private void OnTriggerEnter(Collider col)
    {
        switch (col.gameObject.tag)
        {
            case "Turret":
                //Instantiate(explosion, col.gameObject.transform.position, Quaternion.identity);
                Destroy(gameObject);
                target = null;
                break;
        }
    }

    void MoveEnemy()
    {
        if (target != null)
        {
            directionToTarget = (target.transform.position - transform.position).normalized;
            rb.velocity = new Vector3(directionToTarget.x * moveSpeed, directionToTarget.y * moveSpeed, directionToTarget.z*moveSpeed);
        }
        else
            rb.velocity = Vector3.zero;
    }
}
