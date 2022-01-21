using UnityEngine;
using UnityEngine.EventSystems;

public class UIHandlerSwipe : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public Transform Player;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Vector2 delta = eventData.delta;

        if (Mathf.Abs(delta.x) > Mathf.Abs(delta.y))
        {
            Vector3 position = Player.position;
            position.x += 1.5f * delta.x * 0.05f;
            Player.position = position;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {

    }
}


