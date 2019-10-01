using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressController : MonoBehaviour {

    public GameObject level;
    public GameObject bestUsers;

    public GameObject level2;
    public GameObject bestUsers2;

    public GameObject level3;
    public GameObject bestUsers3;

    public GameObject level4;
    public GameObject bestUsers4;

    private int i = 1;
    private int j = 0;
    
    private Vector3 targetAngle10;
    private Vector3 targetAngle11;

    private Vector3 targetAngle20;
    private Vector3 targetAngle21;

    private Vector3 targetAngle30;
    private Vector3 targetAngle31;

    private Vector3 targetAngle40;
    private Vector3 targetAngle41;

    private readonly float smooth = 5f;

    public void Start()
    {
        targetAngle10 = level.transform.eulerAngles + 90f * Vector3.up;
        targetAngle11 = bestUsers.transform.eulerAngles + 205f * Vector3.up;

        targetAngle20 = level2.transform.eulerAngles + 90f * Vector3.up;
        targetAngle21 = bestUsers2.transform.eulerAngles + 205f * Vector3.up;

        targetAngle30 = level3.transform.eulerAngles + 90f * Vector3.up;
        targetAngle31 = bestUsers3.transform.eulerAngles + 205f * Vector3.up;

        targetAngle40 = level4.transform.eulerAngles + 90f * Vector3.up;
        targetAngle41 = bestUsers4.transform.eulerAngles + 205f * Vector3.up;
    }

    public void Update()
    {
        RotEffect2(i,j);
    }

    public void RotEffect2(int i, int j)
    {
        switch (i)
        {
            case 1:
                switch (j)
                {
                    case 0:
                        level.transform.eulerAngles = Vector3.Lerp(level.transform.eulerAngles, targetAngle10, smooth * Time.deltaTime);

                        if (level.transform.eulerAngles.y >= 50)
                        {
                            bestUsers.SetActive(true);
                            bestUsers.transform.eulerAngles = Vector3.Lerp(bestUsers.transform.eulerAngles, targetAngle11, smooth * Time.deltaTime);
                            level.SetActive(false);

                            if (bestUsers.transform.eulerAngles.y >= 358)
                            {
                                this.gameObject.SetActive(false);
                            }
                        }
                        break;
                    case 1:
                        bestUsers.transform.eulerAngles = Vector3.Lerp(bestUsers.transform.eulerAngles, targetAngle10, smooth * Time.deltaTime);

                        if (bestUsers.transform.eulerAngles.y >= 85)
                        {
                            level.SetActive(true);
                            level.transform.eulerAngles = Vector3.Lerp(level.transform.eulerAngles, targetAngle11, smooth * Time.deltaTime);
                            bestUsers.SetActive(false);

                            if (level.transform.eulerAngles.y >= 358)
                            {
                                this.gameObject.SetActive(false);
                            }
                        }
                        break;
                }
                break;
            case 2:
                switch (j)
                {
                    case 0:
                        level2.transform.eulerAngles = Vector3.Lerp(level2.transform.eulerAngles, targetAngle20, smooth * Time.deltaTime);

                        if (level2.transform.eulerAngles.y >= 50)
                        {
                            bestUsers2.SetActive(true);
                            bestUsers2.transform.eulerAngles = Vector3.Lerp(bestUsers2.transform.eulerAngles, targetAngle21, smooth * Time.deltaTime);
                            level2.SetActive(false);

                            if (bestUsers2.transform.eulerAngles.y >= 358)
                            {
                                this.gameObject.SetActive(false);
                            }
                        }
                        break;
                    case 1:
                        bestUsers2.transform.eulerAngles = Vector3.Lerp(bestUsers2.transform.eulerAngles, targetAngle20, smooth * Time.deltaTime);

                        if (bestUsers2.transform.eulerAngles.y >= 85)
                        {
                            level2.SetActive(true);
                            level2.transform.eulerAngles = Vector3.Lerp(level2.transform.eulerAngles, targetAngle21, smooth * Time.deltaTime);
                            bestUsers2.SetActive(false);

                            if (level2.transform.eulerAngles.y >= 358)
                            {
                                this.gameObject.SetActive(false);
                            }
                        }
                        break;
                }
                break;
            case 3:
                switch (j)
                {
                    case 0:
                        level3.transform.eulerAngles = Vector3.Lerp(level3.transform.eulerAngles, targetAngle30, smooth * Time.deltaTime);

                        if (level3.transform.eulerAngles.y >= 50)
                        {
                            bestUsers3.SetActive(true);
                            bestUsers3.transform.eulerAngles = Vector3.Lerp(bestUsers3.transform.eulerAngles, targetAngle31, smooth * Time.deltaTime);
                            level3.SetActive(false);

                            if (bestUsers3.transform.eulerAngles.y >= 358)
                            {
                                this.gameObject.SetActive(false);
                            }
                        }
                        break;
                    case 1:
                        bestUsers3.transform.eulerAngles = Vector3.Lerp(bestUsers3.transform.eulerAngles, targetAngle30, smooth * Time.deltaTime);

                        if (bestUsers3.transform.eulerAngles.y >= 85)
                        {
                            level3.SetActive(true);
                            level3.transform.eulerAngles = Vector3.Lerp(level3.transform.eulerAngles, targetAngle31, smooth * Time.deltaTime);
                            bestUsers3.SetActive(false);

                            if (level3.transform.eulerAngles.y >= 358)
                            {
                                this.gameObject.SetActive(false);
                            }
                        }
                        break;
                }
                break;
            case 4:
                switch (j)
                {
                    case 0:
                        level4.transform.eulerAngles = Vector3.Lerp(level4.transform.eulerAngles, targetAngle40, smooth * Time.deltaTime);

                        if (level4.transform.eulerAngles.y >= 50)
                        {
                            bestUsers4.SetActive(true);
                            bestUsers4.transform.eulerAngles = Vector3.Lerp(bestUsers4.transform.eulerAngles, targetAngle41, smooth * Time.deltaTime);
                            level4.SetActive(false);

                            if (bestUsers4.transform.eulerAngles.y >= 358)
                            {
                                this.gameObject.SetActive(false);
                            }
                        }
                        break;
                    case 1:
                        bestUsers4.transform.eulerAngles = Vector3.Lerp(bestUsers4.transform.eulerAngles, targetAngle40, smooth * Time.deltaTime);

                        if (bestUsers4.transform.eulerAngles.y >= 85)
                        {
                            level4.SetActive(true);
                            level4.transform.eulerAngles = Vector3.Lerp(level4.transform.eulerAngles, targetAngle41, smooth * Time.deltaTime);
                            bestUsers4.SetActive(false);

                            if (level4.transform.eulerAngles.y >= 358)
                            {
                                this.gameObject.SetActive(false);
                            }
                        }
                        break;
                }
                break;

        }
    }

    public void setI(int variable)
    {
        i = variable;
    }

    public void SetJ(int varible)
    {
        j = varible;
    }

    public void ActivateScript()
    {
        this.gameObject.SetActive(true);
    }

}
