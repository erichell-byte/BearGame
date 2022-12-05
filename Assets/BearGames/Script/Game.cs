using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    // [SerializeField] private TransformMovement _transformMovement;
    [SerializeField] private KeyBoardInput _keyBoardInput;
    [SerializeField] private GameObject _startScreen;
    [SerializeField] private GameObject _settingsScreen;
    [SerializeField] private GameObject _lossScreen;

    public bool IsGameActive { get; private set; }

    public enum State
    {
        Playing,
        Won,
        Loss
    }

    public State CurrentState { get; private set; }

    public void StarGame()
    {
        IsGameActive = true;
        _startScreen.SetActive(false);
        // _transformMovement.enabled = true;
        _keyBoardInput.enabled = true;
    }

    public void OnPlayerDied()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Loss;
        // _transformMovement.enabled = false;
        _keyBoardInput.enabled = false;
        Debug.Log("Game Over!");
        _lossScreen.SetActive(true);
        
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void BackToMenu()
    {
        SceneManager.LoadScene(1);
    }
}
