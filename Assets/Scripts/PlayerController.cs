using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float MoveSpeed;
    public float Sensitivity;

    public Rigidbody Rigidbody;
    public Transform Transform;

    public Game Game;

    private void FixedUpdate()
    {
        Rigidbody.velocity = new Vector3(-MoveSpeed, 0, 0);

        if (Input.GetKey(KeyCode.A))
        {
            Transform.Translate(Vector3.left * Sensitivity * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Transform.Translate(-Vector3.left * Sensitivity * Time.deltaTime);
        }
            
    }

    public void Die()
    {
        Game.OnPlayerDied();
        Game.ShowLossScreen();
        Rigidbody.velocity = Vector3.zero;
    }

    public void ReachFinish()
    {
        Game.OnPlayerReachedFinish();
        Game.ShowFinishScreen();
        Rigidbody.velocity = Vector3.zero;
    }
}