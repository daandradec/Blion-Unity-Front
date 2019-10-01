using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour {

    public bool tohome = false;
    public bool toS2 = false;
    public bool toS3 = false;
    public bool toS4 = false;
    public bool toS5 = false;
    public int speed = 5000;

    private float step;

    [HideInInspector] public int activeWindow = 1;

    Vector3 home = new Vector3();
    Vector3 s2 = new Vector3();
    Vector3 s3 = new Vector3();
    Vector3 s4 = new Vector3();
    Vector3 s5 = new Vector3();

    private void Start()
    {
        step = speed * Time.deltaTime;
        home = new Vector3(0, transform.position.y, transform.position.z);
        s2 = new Vector3(500, transform.position.y, transform.position.z);
        s3 = new Vector3(-500, transform.position.y, transform.position.z);
        s4 = new Vector3(1000, transform.position.y, transform.position.z);
        s5 = new Vector3(-1000, transform.position.y, transform.position.z);
    }

    void Update ()
    {
        if (toS2)
        {
            if (tohome == true && toS4 == false )
            {
                transform.position = Vector3.MoveTowards(transform.position, home, step);
                activeWindow = 1;
                if (transform.position == home)
                {
                    toS2 = false;
                    tohome = false;
                }
            }
            else if (toS4)
            {
                transform.position = Vector3.MoveTowards(transform.position, s4, step);
                activeWindow = 4;
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, s2, step);
                activeWindow = 2;
            }
        }
        else if (toS3)
        {
            if (tohome==true && toS5 == false)
            {
                transform.position = Vector3.MoveTowards(transform.position, home, step);
                activeWindow = 1;
                if (transform.position == home)
                {
                    toS3 = false;
                    tohome = false;
                }
            }
            else if (toS5)
            {
                transform.position = Vector3.MoveTowards(transform.position, s5, step);
                activeWindow = 5;
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, s3, step);
                activeWindow = 3;
            }
        }
	}
}
