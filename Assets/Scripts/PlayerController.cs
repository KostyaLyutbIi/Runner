using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float Speed;
    public Rigidbody Rigidbody;

    public event OnSwipeInput SwipeEvent;
    public delegate void OnSwipeInput(Vector3 direction);

    private void FixedUpdate()
    {
        Rigidbody.velocity = new Vector3(-Speed, 0, 0);
    }
}