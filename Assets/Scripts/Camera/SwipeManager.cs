using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeManager : MonoBehaviour {

    private bool tap, swipeLeft, swipeRight, swipeUp, swipeDown;
    private bool isDraging = false;
    private Vector2 startTouch, swipeDelta;

    private float x, y;

    public void Update()
    {
        swipeLeft = swipeRight = tap =swipeDown = swipeUp = false;

        #region Standalone inputs
        if (Input.GetMouseButtonDown(0))
        {
            /*if (WindowController.active_button == true)
            {
                WindowController.active_button = false;
                return;
            }*/
            tap = true;
            isDraging = true;
            startTouch = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDraging = false;
            Reset();
        }
        #endregion

        #region Mobile inputs
        if (Input.touches.Length != 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                if (WindowController.active_button == true)
                {
                    WindowController.active_button = false;
                    return;
                }
                tap = true;
                isDraging = true;
                startTouch = Input.touches[0].position;
            }
            else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                isDraging = false;
                Reset();
            }
        }
        #endregion

        // Distance
        swipeDelta = Vector2.zero;

        if (isDraging)
        {
            if (Input.touches.Length != 0)
            {
                swipeDelta = Input.touches[0].position - startTouch;
            }
            else if (Input.GetMouseButton(0))
            {
                swipeDelta = (Vector2)Input.mousePosition - startTouch;
            }
        }

        if (swipeDelta.magnitude > 125)
        {
            x = swipeDelta.x;
            y = swipeDelta.y;

            if (Mathf.Abs(x) > Mathf.Abs(y))
            {
                if (x < 0)
                {
                    swipeLeft = true;
                }
                else
                {
                    swipeRight = true;
                }
            }
            if (Mathf.Abs(y) > Mathf.Abs(x))
            {
                if (y < 0)
                {
                    /*if (WindowController.active_button == true)
                    {
                        return;
                    }*/
                    swipeDown = true;
                }
                else
                {
                    /*if (WindowController.active_button == true)
                    {
                        return;
                    }*/
                    swipeUp = true;
                }
            }
            Reset();
        }

    }

    private void Reset()
    {
        startTouch = swipeDelta = Vector2.zero;
        isDraging = false;
    }

    public Vector2 StartTouch { get { return startTouch; } }
    public Vector2 SwipeDelta { get { return swipeDelta; } }
    public bool Tap { get { return tap; } }
    public bool SwipeLeft { get { return swipeLeft; } }
    public bool SwipeRight { get { return swipeRight; } }
    public bool SwipeUp { get { return swipeUp; } }
    public bool SwipeDown { get { return swipeDown; } }
}
