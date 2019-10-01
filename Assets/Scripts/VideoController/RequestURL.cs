using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestURL : MonoBehaviour
{
    public string[] urls;

    private string[] urlsCopy;

    private int links = 10;

    private void Start()
    {
        urls = new string[links];
        urlsCopy = new string[links];
        urlsCopy[0] = "Empty";
    }

    public void E_Request()
    {
        urls[0] = "OK";
          urls[1] = "C:/Users/USUARIO/Documents/Unity Projects/Blion_Interface_16_9/Assets/Videos/EMQG0886.mp4";
        urls[2] = "C:/Users/USUARIO/Documents/Unity Projects/Blion_Interface_16_9/Assets/Videos/EDYM4573.mp4";
        urls[3] = "C:/Users/USUARIO/Documents/Unity Projects/Blion_Interface_16_9/Assets/Videos/BPFK2598.mp4";
        urls[4] = "C:/Users/USUARIO/Documents/Unity Projects/Blion_Interface_16_9/Assets/Videos/BTPG7339.mp4";
        urls[5] = "C:/Users/USUARIO/Documents/Unity Projects/Blion_Interface_16_9/Assets/Videos/BYAC7259.mp4";
        urls[6] = "C:/Users/USUARIO/Documents/Unity Projects/Blion_Interface_16_9/Assets/Videos/CFQP5440.mp4";
        urls[7] = "C:/Users/USUARIO/Documents/Unity Projects/Blion_Interface_16_9/Assets/Videos/CFZE1620.mp4";
        urls[8] = "C:/Users/USUARIO/Documents/Unity Projects/Blion_Interface_16_9/Assets/Videos/CLSI9653.mp4";
        urls[9] = "C:/Users/USUARIO/Documents/Unity Projects/Blion_Interface_16_9/Assets/Videos/CMMZ8890.mp4";
    }

    public void Ex_Request()
    {
        urlsCopy = urls;

        if (urlsCopy[0] != "OK")
        {
            E_Request();
            urlsCopy = urls;
        }
    }

    public string I_Request(int i)
    {
        return urlsCopy[i];
    }

    public void Reset()
    {
        urls = new string[links];
        urlsCopy = new string[links];
        urlsCopy[0] = "Empty";
    }
}
