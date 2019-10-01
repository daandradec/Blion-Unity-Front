using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowController : MonoBehaviour {

    public static int active_window;
    public static bool active_button = false;
    
    public static void ActiveWindow(int id)
    {
        switch (id)
        {
            case 1:
                active_window = id;
                //Debug.Log(active_window);
                break;
            case 2:
                active_window = id;
                //Debug.Log(active_window);
                break;
            case 3:
                active_window = id;
                //Debug.Log(active_window);
                break;
            case 4:
                active_window = id;
                //Debug.Log(active_window);
                break;
            case 5:
                active_window = id;
                //Debug.Log(active_window);
                break;
            default:
                Debug.Log("Window has not yet been established");
                break;
        }
    }

    public void Active_Button(bool active)
    {
        active_button = active;
    }
}

/*
 * 1: Home
 * 2: Ideas
 * 3: User
 * 4: Search
 * 5: Clubs
 */
