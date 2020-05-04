using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField]
    private int _damage = 25;

    private float speed = 2500;
    private ScoreCount _scoreCount;
    private EnemyController _enemyController;

    private void Awake()
    {
        _scoreCount = FindObjectOfType<ScoreCount>();
        _enemyController = FindObjectOfType<EnemyController>();
    }

    private void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.up * speed;
        Destroy(gameObject, 1);
        //get updraded damage from player prefs
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy1")
        {
            _scoreCount.Enemy1Kill();
        }
        else if (other.gameObject.tag == "Enemy2")
        {
            _scoreCount.Enemy2Kill();
        }
        else
        {
            _scoreCount.Enemy3Kill();
        }

        Destroy(gameObject);
    }
}