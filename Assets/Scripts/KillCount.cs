using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCount : MonoBehaviour
{
    public static KillCount instance;
    [SerializeField]
    Text _killCounter = null;
    [HideInInspector]
    public int killCount;

    private void Awake()
    {
        killCount = 0;

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UpdateKillCounterUI()
    {
        killCount++;
        _killCounter.text = killCount.ToString();
    }
}