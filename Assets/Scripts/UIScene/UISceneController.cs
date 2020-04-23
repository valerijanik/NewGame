using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UISceneController : MonoBehaviour
{
    [SerializeField]
    private GameObject _mainMenuView = null;
    [SerializeField]
    private GameObject _characterSelectionView = null;
    [SerializeField]
    private GameObject _settingsView = null;
    [SerializeField]
    private GameObject _creditsView = null;
    [SerializeField]
    private GameObject _turretStats = null;

    private void Awake()
    {
        _mainMenuView.SetActive(true);
    }

    public void OpenCharacterSelectionView()
    {
        _characterSelectionView.SetActive(true);
        _mainMenuView.SetActive(false);
    }

    public void OpenSettingsView()
    {
        _settingsView.SetActive(true);
        _mainMenuView.SetActive(false);
        _creditsView.SetActive(false);
    }

    public void OpenCreditsView()
    {
        _creditsView.SetActive(false);
        _settingsView.SetActive(false);
    }

    public void BackToMainMenuView()
    {
        _settingsView.SetActive(false);
        _characterSelectionView.SetActive(false);
        _mainMenuView.SetActive(true);
    }

    public void OpenGameScene()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenCharacterStats()
    {
        _turretStats.SetActive(true);
    }
}
