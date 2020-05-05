using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurretController : MonoBehaviour
{
    public float turretMaxHealth;
    public float turretCurHealth;

    [SerializeField]
    private Text _turretHealthText = null;

    private float _enemy1Damage;
    private float _enemy2Damage;
    private float _enemy3Damage;

    public Text enemy1DamText;
    public Text enemy2DamText;
    public Text enemy3DamText;
    

    private void Awake()
    {
        turretMaxHealth = 100;
        turretCurHealth = turretMaxHealth;
        UpdateHealthUI();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy1")
        {
            _enemy1Damage = other.gameObject.GetComponent<Enemy1Controller>().enemy1Damage * Time.time / 7;
            turretCurHealth -= _enemy1Damage;

            enemy1DamText.text = _enemy1Damage.ToString();
        }
        else if (other.gameObject.tag == "Enemy2")
        {
            _enemy2Damage = other.gameObject.GetComponent<Enemy2Controller>().enemy2Damage * Time.time / 9;
            turretCurHealth -= _enemy2Damage;

            enemy2DamText.text = _enemy2Damage.ToString();
        }
        else if (other.gameObject.tag == "Enemy3")
        {
            _enemy3Damage = other.gameObject.GetComponent<Enemy3Controller>().enemy3Damage * Time.time / 12;
            turretCurHealth -= _enemy3Damage;

            enemy3DamText.text = _enemy3Damage.ToString();
        }

        Destroy(other);

        UpdateHealthUI();
    }

    public void UpdateHealthUI()
    {
        _turretHealthText.text = turretCurHealth.ToString();
    }
}
