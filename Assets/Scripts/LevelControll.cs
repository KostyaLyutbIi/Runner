using UnityEngine;
using UnityEngine.UI;

public class LevelControll : MonoBehaviour
{
    public GameObject Level;
    public float Speed;

    private void Update()
    {
        Level.transform.position -= new Vector3(0, 0, Speed * Time.deltaTime);
    }
}