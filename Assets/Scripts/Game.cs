using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public GameObject Text;
    private int _points;

    public void UpdatePoints()
    {
        Text.GetComponent<Text>().text = " " + _points;
    }

    public void AddScore (int newPoints)
    {
        _points += newPoints;
        UpdatePoints();
    }
}