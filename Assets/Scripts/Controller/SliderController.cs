using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SliderController : MonoBehaviour, IBeginDragHandler, IDragHandler,IEndDragHandler
{
    public GameObject swipeCamera;
    private SwipeControl swipeDeact;

    public GameObject cMain;

    public GameObject i_sm2;
    public GameObject i_sm1;
    public GameObject iCenter_icon;
    public GameObject iCenter_image;
    public GameObject cButtons;
    public GameObject sliderValue;

    public GameObject UserInter;
    public GameObject progress;
    public GameObject bg;

    private bool value2 = true;
    private Slider slider;
    private Text t_SliderValue;
    private RawImage logo;
    private RawImage centerPic;
    private bool value = true;
    private int alpha = 1;

    public void Start()
    {
        slider = this.GetComponent<Slider>();
        logo = iCenter_icon.GetComponent<RawImage>();
        centerPic = iCenter_image.GetComponent<RawImage>();
        t_SliderValue = sliderValue.GetComponent<Text>();
        swipeDeact = swipeCamera.GetComponent<SwipeControl>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (WindowController.active_window == 2)
        {
            i_sm1.SetActive(false);
        }

        if(WindowController.active_window == 2 && slider.value == 3)
        {
            cButtons.SetActive(false);
        }

        if (WindowController.active_window == 2 && slider.value == 6 && alpha == 0)
        {
            logo.color = new Color(logo.color.r, logo.color.g, logo.color.b, 1f);
            centerPic.color = new Color(centerPic.color.r, centerPic.color.g, centerPic.color.b, 1f);
            alpha = 0;
        }

    }

    public void OnDrag(PointerEventData eventData)
    {
        if (WindowController.active_window == 2 || WindowController.active_window == 1 || WindowController.active_window == 3)
        {
            iCenter_image.SetActive(false);
            sliderValue.SetActive(true);
            t_SliderValue.text = slider.value.ToString();
            swipeDeact.enabled = false;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        WindowController.active_button = false;
        swipeDeact.enabled = true;

        if (WindowController.active_window == 1)
        {
            iCenter_image.SetActive(true);
            sliderValue.SetActive(false);
        }

        if(WindowController.active_window == 1 && slider.value == 1)
        {
            cMain.SetActive(true);
            slider.value = 0;
        }

        if (WindowController.active_window == 3 && slider.value == 1)
        {
            UserInter.SetActive(!value2);
            progress.SetActive(value2);
            bg.SetActive(value2);
            value2 = !value2;
        }

        if (WindowController.active_window == 3)
        {
            iCenter_image.SetActive(true);
            sliderValue.SetActive(false);
            slider.value = 0f;
        }

        if (WindowController.active_window == 2)
        {
            iCenter_image.SetActive(true);
            sliderValue.SetActive(false);
        }

        if (WindowController.active_window == 2 && slider.value == 1)
        {
            i_sm2.SetActive(value);
            value = !value;
        }

        if (WindowController.active_window == 2 && slider.value == 3)
        {
            cButtons.SetActive(true);
        }

        if (WindowController.active_window == 2 && slider.value == 3 && i_sm2.activeSelf == true)
        {
            i_sm2.SetActive(false);
            value = true;
        }

        if (WindowController.active_window == 2 && slider.value != 3 && slider.value != 6)
        {
            i_sm1.SetActive(true);
            slider.value = 0f;
        }

        if (WindowController.active_window == 2 && slider.value == 6)
        {
            i_sm2.SetActive(false);
            value = true;
            logo.color = new Color(logo.color.r, logo.color.g, logo.color.b, 0f);
            centerPic.color = new Color(centerPic.color.r, centerPic.color.g, centerPic.color.b, 0f);
            alpha = 0;
        }
    }

    public void X_Button()
    {
        if (WindowController.active_window == 2 && slider.value == 0)
        {
            i_sm2.SetActive(false);
            value = true;
        }
    } 
}
