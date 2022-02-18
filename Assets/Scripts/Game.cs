using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public PlayerController Controls;
    public LevelControll LevelControls;

    public GameObject Text;

    public GameObject LossScreen;
    public GameObject LosePoints;

    public GameObject WonScreen;
    public GameObject WonPoints;

    private int _points; 

    public enum State
    {
        Playing,
        Won,
        Loss,
    }

    public State CurrentState { get; private set; }

    public void OnPlayerDied()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Loss;
        Controls.enabled = false;
        LevelControls.enabled = false;
    }

    public void OnPlayerReachedFinish()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Won;
        Controls.enabled = false;
        LevelControls.enabled = false;
    }

    public void UpdatePoints()
    {
        Text.GetComponent<Text>().text = " " + _points;
    }

    public void AddScore (int newPoints)
    {
        _points += newPoints;
        UpdatePoints();
    }

    public void ShowLossScreen()
    {
        LossScreen.SetActive(true);
        LosePoints.GetComponent<Text>().text = "Points: " + _points;
    }

    public void ShowFinishScreen()
    {
        WonScreen.SetActive(true);
        WonPoints.GetComponent<Text>().text = "Points: " + _points;
    }
}