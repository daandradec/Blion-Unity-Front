using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeControl : MonoBehaviour {

    public SwipeManager swipeManager;
    public GameObject cam;

    public ChangingImage changeImage;

    public GameObject screen1;
    public GameObject screen2;

    private MoveCam move;

    public void Start()
    {
        move = cam.GetComponent<MoveCam>();
        WindowController.ActiveWindow(1);
    }

    public void Update()
    {
        if (WindowController.active_window == 2 && screen2.activeSelf == true || screen1.activeSelf == true)
        {
            return;
        }

        if (swipeManager.SwipeUp)
        {
            if (WindowController.active_window == 2)
            {
                SpawnPosts.swipeUp = true;
            }
            Debug.Log("SwipeUp");
        }
        else if (swipeManager.SwipeLeft)
        {
            if (move.tohome == false)
            {
                if (move.toS3 == true)
                {
                    //if (move.toS5 == true)
                    //{
                    //    move.toS5 = false;
                    //}
                    //else
                    //{
                        move.tohome = true;
                    WindowController.ActiveWindow(1);
                    changeImage.SetImage(3);
                    //}
                }
                else
                {
                    //if (move.toS2 == true)
                    //{
                    //    move.toS4 = true;
                    //}
                    //else
                    //{
                        move.toS2 = true;
                    WindowController.ActiveWindow(3);
                    changeImage.SetImage(5);
                    //}
                }
            }

        }
        else if (swipeManager.SwipeRight)
        {
            if (move.tohome == false)
            {
                if (move.toS2 == true)
                {
                    //if (move.toS4 == true)
                    //{
                    //    move.toS4 = false;
                    //}
                    //else
                    //{
                        move.tohome = true;
                    WindowController.ActiveWindow(1);
                    changeImage.SetImage(3);
                    //}
                }
                else
                {
                    //if (move.toS3 == true)
                    //{
                    //    move.toS5 = true;
                    //}
                    //else
                    //{
                        move.toS3 = true;
                    WindowController.ActiveWindow(2);
                    changeImage.SetImage(1);
                    //}
                }
            }

        }
        else if (swipeManager.SwipeDown)
        {
            if (WindowController.active_window == 2){
                SpawnPosts.swipeDown = true;
            }
            Debug.Log("SwipeDown");
        }
        
    }
}
