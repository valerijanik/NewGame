using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BulletController : MonoBehaviour
{
    //[SerializeField]
    //private int _damage = 25;
    [SerializeField]
    private int speed = 100;


    private void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.up * speed;
        Destroy(gameObject, 1);

        //get upgraded damage from player prefs
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy1")
        {
            GameEvents.current.Enemy1KillTrigger();
        }
        else if (other.gameObject.tag == "Enemy2")
        {
            GameEvents.current.Enemy2KillTrigger();
        }
        else if (other.gameObject.tag == "Enemy3")
        {
            GameEvents.current.Enemy3KillTrigger();
        }

        Destroy(gameObject);
    }
}