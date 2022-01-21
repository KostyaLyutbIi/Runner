using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform Player;

    private Vector3 _offset;

    void Start()
    {
        _offset = transform.position - Player.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(Player.position.x + _offset.x, Player.position.y + _offset.y, 0);
    }
}
