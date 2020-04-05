using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private float speed = 2500;

    private void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.up * speed;
        Destroy(gameObject, 1);
    }
}