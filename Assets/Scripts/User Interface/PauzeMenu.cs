using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Originally just a set of components.
// But a mix of events was required to make this work well.
public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    private GameEvent OnPressPause;

    [SerializeField]
    private BoolEvent OnPauseGame;

    [SerializeField, Tooltip("Target to influcence")]
    private GameObject target;

    private bool onPausedGame;

    private void OnEnable()
    {
        OnPressPause.AddListener(OnPausePressed);
        OnPauseGame.AddListener(OnGamePaused);
    }

    private void OnDisable()
    {
        OnPressPause.RemoveListener(OnPausePressed);
        OnPauseGame.RemoveListener(OnGamePaused);
    }

    private void OnGamePaused(bool state)
    {
        onPausedGame = state;
    }

    private void OnPausePressed()
    {
        Debug.Log("Pause pressed");

        target.gameObject.SetActive(onPausedGame);
    }
}