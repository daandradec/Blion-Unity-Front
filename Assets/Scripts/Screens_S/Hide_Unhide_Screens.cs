using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide_Unhide_Screens : MonoBehaviour {

    public GameObject screen1;
    public GameObject screen2;

    public GameObject close;
    
    private bool value = true;

    public void ShowScreen(int i)
    {
        switch (i)
        {
            case 1:
                screen1.SetActive(value);
                value = !value;
                break;
            case 2:
                screen2.SetActive(value);
                close.SetActive(value);
                value = !value;
                break;
            default:
                Debug.Log("ShowInScreen error.");
                break;
        }
    }

    public void Restart()
    {
        value = true;
    }

}
