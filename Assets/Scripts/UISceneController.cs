using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UISceneController : MonoBehaviour
{
    public void OpenGameScene()
    {
        SceneManager.LoadScene(1);
    }
}
