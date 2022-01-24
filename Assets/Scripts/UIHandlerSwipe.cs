using UnityEngine;
using UnityEngine.EventSystems;

public class UIHandlerSwipe : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public Transform Player;
    public float Sensitivity;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Vector3 delta = eventData.delta;

        if (Mathf.Abs(delta.x) > Mathf.Abs(delta.y))
        {
            Vector3 position = Player.position;
            position.z += 0.05f * delta.x * Sensitivity * 0.05f;
            Player.position = position;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {

    }
}


