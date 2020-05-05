using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretControl : MonoBehaviour
{
    [SerializeField]
    private GameObject turret = null;

    public void TurnTurretLeft()
    {
        turret.transform.Rotate(0, 0, 60);
    }

    public void TurnTurretRight()
    {
        turret.transform.Rotate(0, 0, -60);
    }
}
