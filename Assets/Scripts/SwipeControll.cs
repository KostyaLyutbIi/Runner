using UnityEngine;

public class SwipeControll : MonoBehaviour
{
    private bool isDragging;
    private Vector2 _tapPoint;
    private Vector2 _swipeDelta;
    private float _minSwipeDelta = 10000;

    public enum SwipeType
    {
        Left,
        Right
    }

    public delegate void OnSwipeInput(SwipeType type);
    public static event OnSwipeInput SwipeEvent;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            _tapPoint = Input.mousePosition;
        }

        else if (Input.GetMouseButtonUp(0))
            ResetSwipe();

        CalculateSwipe();
    }

    private void ResetSwipe()
    {
        isDragging = false;
        _tapPoint = _swipeDelta = Vector2.zero;
    }

    private void CalculateSwipe()
    {
        _swipeDelta = Vector2.zero;

        if (isDragging)
        {
            if (Input.GetMouseButton(0))
                _swipeDelta = (Vector2)Input.mousePosition - _tapPoint;
            else if (Input.touchCount > 0)
                _swipeDelta = Input.touches[0].position - _tapPoint;
        }

        if (_swipeDelta.magnitude > _minSwipeDelta)
        {
            if(SwipeEvent!= null)
            {
                if (Mathf.Abs(_swipeDelta.x) > Mathf.Abs(_swipeDelta.y))
                    SwipeEvent(_swipeDelta.x < 0 ? SwipeType.Left : SwipeType.Right);
            }
        }

        ResetSwipe();
  
    }

}
