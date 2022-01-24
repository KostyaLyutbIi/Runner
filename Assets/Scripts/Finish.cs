using UnityEngine;

public class Finish : MonoBehaviour
{
    public PlayerController Player;

    private void OnTriggerEnter(Collider other)
    {
        Player.ReachFinish();
    }
}
