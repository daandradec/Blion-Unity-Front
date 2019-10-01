using UnityEngine;
using UnityEngine.UI;

public class ChangingImage : MonoBehaviour {

    public GameObject iCenter;

    public Texture user;
    public Texture search;
    public Texture iCenterPic;
    //public Texture clubs;
    public Texture ideas;

    public GameObject btn_Screen_User;
    //public GameObject btn_Screen_Clubs;
    public GameObject btn_Screen_iCenter;
    public GameObject btn_Screen_Search;
    public GameObject btn_Screen_Ideas;

    public GameObject btn_Show_User;
    //public GameObject btn_Show_Clubs;
    public GameObject btn_Show_iCenter;
    //public GameObject btn_Show_Search;
    public GameObject btn_Show_Ideas;

    private RawImage texture;
    private bool value = false;

    public void Start()
    {
        texture = iCenter.GetComponent<RawImage>();
        texture.texture = iCenterPic;
    }

    public void SetImage(int i)
    {
        switch (i)
        {
            case 1:
                texture.texture = ideas;
                //*Btn_Show(false, true, true, false, true, false, true, false, true, false);
                break;
            case 2:
                texture.texture = search;
                //*Btn_Show(true, false, false, true, true, false, true, false, true, false);
                break;
            case 3:
                texture.texture = iCenterPic;
                //*Btn_Show(true, false, true, false, false, true, true, false, true, false);
                break;
            /*case 4:
                texture.texture = clubs;
                Btn_Show(true, false, true, false, true, false, false, true, true, false);
                break;*/
            case 5:
                texture.texture = user;
                //*Btn_Show(true, false, true, false, true, false, true, false, false, true);
                break;
            case 6:
                iCenter.SetActive(value);
                value = !value;
                break;
            default:
                Debug.Log("Image Center error");
                break;
        }
    }

    /*public void Btn_Show(bool b1, bool b2, bool b3, bool b4, bool b5, bool b6, bool b7, bool b8, bool b9, bool b10)
    {
        btn_Screen_Ideas.SetActive(b1);
        btn_Show_Ideas.SetActive(b2);

        btn_Screen_Search.SetActive(b3);
        //btn_Show_Search.SetActive(b4);

        btn_Screen_iCenter.SetActive(b5);
        btn_Show_iCenter.SetActive(b6);

        /*btn_Screen_Clubs.SetActive(b7);
        btn_Show_Clubs.SetActive(b8);

        btn_Screen_User.SetActive(b9);
        btn_Show_User.SetActive(b10);
    }*/

}
