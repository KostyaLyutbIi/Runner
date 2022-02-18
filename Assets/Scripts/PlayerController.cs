using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public Game Game;
    public Swipe Swipe;
    public Transform Player;
    public float Sensitivite;

    private Vector3 _position;

    private void Update()
    {
        if (Swipe.swipeLeft)
            _position += Vector3.left;

        if (Swipe.swipeRight)
            _position += Vector3.right;

        Player.transform.position = Vector3.MoveTowards(Player.transform.position, _position * 2f, Sensitivite * Time.deltaTime);
    }

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
