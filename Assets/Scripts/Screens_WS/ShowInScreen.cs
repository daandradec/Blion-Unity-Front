using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInScreen : MonoBehaviour {

    public GameObject i_sm2;
    public GameObject h_sm2;
    public GameObject u_sm2;
    public GameObject msg;
    public GameObject heart_bg;

    private bool value = true;
    private bool active_msg = true;
    private bool like = true;

    public void ShowSM(int i)
    {
        switch (i)
        {
            case 1:
                i_sm2.SetActive(value);
                value = !value;
                h_sm2.SetActive(false);
                u_sm2.SetActive(false);
                break;
            case 3:
                h_sm2.SetActive(value);
                value = !value;
                i_sm2.SetActive(false);
                u_sm2.SetActive(false);
                break;
            case 5:
                u_sm2.SetActive(value);
                value = !value;
                i_sm2.SetActive(false);
                h_sm2.SetActive(false);
                break;
            case 6:
                msg.SetActive(active_msg);
                active_msg = !active_msg;
                break;
            case 7:
                heart_bg.SetActive(like);
                like = !like;
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
