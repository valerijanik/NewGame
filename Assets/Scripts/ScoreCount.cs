using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ScoreCount : MonoBehaviour
{
    public Text scoreText;

    [HideInInspector]
    public int score;

    [SerializeField]
    private int scoreForEnemy1 = 1;
    [SerializeField]
    private int scoreForEnemy2 = 2;
    [SerializeField]
    private int scoreForEnemy3 = 5;



    private void Awake()
    {
        score = 0;
        GameEvents.current.onEnemy1KillTrigger += Enemy1Kill;
        GameEvents.current.onEnemy2KillTrigger += Enemy2Kill;
        GameEvents.current.onEnemy3KillTrigger += Enemy3Kill;
    }

    public void Enemy1Kill()
    {
        score += scoreForEnemy1;
        UpdateScoreUI();
    }

    public void Enemy2Kill()
    {
        score += scoreForEnemy2;
        UpdateScoreUI();
    }

    public void Enemy3Kill()
    {
        score += scoreForEnemy3;
        UpdateScoreUI();
    }

    public void UpdateScoreUI()
    {
        scoreText.text = score.ToString();
    }
}