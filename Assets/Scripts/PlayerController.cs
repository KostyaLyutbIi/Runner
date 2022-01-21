using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float Speed;
    public Rigidbody Rigidbody;

    private void FixedUpdate()
        
    {
        Rigidbody.velocity = new Vector3(-Speed, 0, 0);
    }

}