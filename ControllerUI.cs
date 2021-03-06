﻿using UnityEngine;


public class ControllerUI : MonoBehaviour
{
    #region Field

    [SerializeField] private GameObject _pauseMenuUI;
    private bool _isPaused = false;

    #endregion


    #region UnityMethods

    private void Update()
    {
        if (_pauseMenuUI.activeInHierarchy)
            _isPaused = true;
        else
            _isPaused = false;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_isPaused)
            {
                ReturnToGame();
            }
            else
            {
                Pause();
            }
        }
    }

    #endregion


    #region Methods

    public void Pause()
    {
        _pauseMenuUI.SetActive(true);
        Time.timeScale = 0.0f;
        _isPaused = true;
    }

    public void ReturnToGame()
    {
        _pauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        _isPaused = false;
    }

    public void Exit()
    {
        Application.Quit();
    }

    #endregion
}
