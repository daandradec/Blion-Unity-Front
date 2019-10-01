using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLController : MonoBehaviour
{
    // I can't be a number
    public static int i = 1;

    public static void NextVideo(int j)
    {
        i = j + 1;
        Debug.Log(i);
    }
    public static void PreVideo(int j)
    {
        i = j - 1;
    }
}
