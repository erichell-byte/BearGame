using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _startScreen;
    [SerializeField] private GameObject _settingsScreen;

    public void LevelToLoad()
    {
        SceneManager.LoadScene(2);
    }
}
