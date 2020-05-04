using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    [SerializeField]
    Text scoreText = null;
    [HideInInspector]
    public int score;

    private void Awake()
    {
        score = 0;
    }

    public void Enemy1Kill()
    {
        score += 1;
        UpdateScoreCounterUI();
    }

    public void Enemy2Kill()
    {
        score += 2;
        UpdateScoreCounterUI();
    }

    public void Enemy3Kill()
    {
        score += 5;
        UpdateScoreCounterUI();
    }

    public void UpdateScoreCounterUI()
    {
        scoreText.text = score.ToString();
    }
}