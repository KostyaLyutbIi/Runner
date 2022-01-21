using UnityEngine;

public class Money : MonoBehaviour
{
    public int Points;
    public Game Game;

    private void OnTriggerEnter(Collider other)
    {
        Game.AddScore(Points);
        Destroy(gameObject);
    }
}