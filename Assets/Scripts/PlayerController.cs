using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public Game Game;

    public void Die()
    {
        Game.OnPlayerDied();
        Game.ShowLossScreen();
    }

    public void ReachFinish()
    {
        Game.OnPlayerReachedFinish();
        Game.ShowFinishScreen();
    }
}