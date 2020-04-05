using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButtonController : MonoBehaviour
{
    [SerializeField]
    private GameObject _pauseMenu = null;
    [SerializeField]
    private GameObject _settingsMenu = null;
    [SerializeField]
    private GameObject _pauseButton = null;

    private void Awake()
    {
        Time.timeScale = 1f;
    }

    public void FleeGame()
    {
        SceneManager.LoadScene(0);
    }

    public void OpenPauseMenu()
    {
        Time.timeScale = 0f;

        if (Time.timeScale == 0f)
        {
            _pauseMenu.SetActive(true);
            _pauseButton.SetActive(false);
        }
    }

    public void OpenSettings()
    {
        Time.timeScale = 0f;
        _settingsMenu.SetActive(true);
        _pauseMenu.SetActive(false);
    }

    public void CloseSettings()
    {
        _settingsMenu.SetActive(false);
        _pauseMenu.SetActive(true);
    }

    public void BackToGame()
    {
        _pauseMenu.SetActive(false);
        _settingsMenu.SetActive(false);
        _pauseButton.SetActive(true);
        Time.timeScale = 1f;
    }
}
