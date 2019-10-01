using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPosts : MonoBehaviour
{
    public GameObject cPost;
    public GameObject prefab;

    public static bool swipeUp;
    public static bool swipeDown;

    public void Update()
    {
        if (WindowController.active_window == 2)
        {
            if (cPost.tag != "active")
            {
                cPost.tag = "active";
            }
            
            if (!swipeUp && !swipeDown)
            {
                return;
            }
            else if (swipeUp)
            {
                URLController.NextVideo(URLController.i);
                Destroy(cPost);
                GameObject post = Instantiate(prefab, new Vector3(-500, 0, 0), Quaternion.identity) as GameObject;
                post.transform.SetParent(this.gameObject.transform);
                cPost = post;
                swipeUp = false;
            }
            else if (swipeDown)
            {
                if(URLController.i <= 1)
                {
                    swipeDown = false;
                    return;
                }
                else if (URLController.i > 1)
                {
                    URLController.PreVideo(URLController.i);
                    Destroy(cPost);
                    GameObject post = Instantiate(prefab, new Vector3(-500, 0, 0), Quaternion.identity) as GameObject;
                    post.transform.SetParent(this.gameObject.transform);
                    cPost = post;
                    swipeDown = false;
                }
            }
        }
        else
        {
            return;
        }
        
        
        
    }

}
