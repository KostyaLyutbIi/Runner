using UnityEngine;

public class Swipe : MonoBehaviour
{
    private Vector2 _startTouch;
    private Vector2 _swipeDelta;
    private bool _tap;
    private bool _swipeLeft;
    private bool _swipeRight;
    private bool _isDragging = false;

    private void Update()
    {
        _tap = _swipeLeft = _swipeRight = false;

        if (Input.GetMouseButtonDown(0))
        {
            _tap = true;
            _isDragging = true;
            _startTouch = Input.mousePosition;
        }

        else if (Input.GetMouseButtonUp(0))
        {
            _isDragging = false;
            Reset();
        }

        // distance
        _swipeDelta = Vector2.zero;

        if (_isDragging)
        {
            if (Input.GetMouseButton(0))
                _swipeDelta = (Vector2)Input.mousePosition - _startTouch;
        }

        // dead zone
        if (_swipeDelta.magnitude > 100)
        {
            float x = _swipeDelta.x;

            if (x < 0)
                _swipeLeft = true;
            else
                _swipeRight = true;

            Reset();
        }
    }

    private void Reset()
    {
        _startTouch = _swipeDelta = Vector2.zero;
        _isDragging = false;
    }

    public Vector3 swipeDelta { get { return _swipeDelta; } }
    public bool tap { get { return _tap; } }
    public bool swipeLeft { get { return _swipeLeft; } }
    public bool swipeRight { get { return _swipeRight; } }
}