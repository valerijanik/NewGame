using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event Action onEnemy1KillTrigger;
    public void Enemy1KillTrigger()
    {
        if (onEnemy1KillTrigger != null)
        {
            onEnemy1KillTrigger();
        }
    }

    public event Action onEnemy2KillTrigger;
    public void Enemy2KillTrigger()
    {
        if (onEnemy2KillTrigger != null)
        {
            onEnemy2KillTrigger();
        }
    }

    public event Action onEnemy3KillTrigger;
    public void Enemy3KillTrigger()
    {
        if(onEnemy3KillTrigger != null)
        {
            onEnemy3KillTrigger();
        }
    }
}
