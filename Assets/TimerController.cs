using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    private int playedTime = 0;
    private int seconds = 0;
    private int minutes = 0;
    private int hours = 0;

    [SerializeField]
    private Text timerText = null;

    private void Start()
    {
        StartCoroutine("PlayedTime");
    }

    private IEnumerator PlayedTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            playedTime += 1;
            seconds = (playedTime % 60);
            minutes = (playedTime / 60) % 60;
            hours = (playedTime / 3600) % 24;
        }
    }

    private void OnGUI()
    {
        timerText.text = "Time played: " + minutes.ToString() + ":" + seconds.ToString();
    }
}
