using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    public GameObject turret;
    public int turretHealth = 100;

    public void TurnTurretLeft()
    {
        turret.transform.Rotate(0, 0, -60);
    }

    public void TurnTurretRight()
    {
        turret.transform.Rotate(0, 0, 60);
    }
}
