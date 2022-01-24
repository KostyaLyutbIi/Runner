using UnityEngine;

public class Block : MonoBehaviour
{
    public PlayerController Player;

    private void OnCollisionEnter(Collision collision)
    {
        Player.Die();
    }
}
