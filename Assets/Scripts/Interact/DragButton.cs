using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragButton : MonoBehaviour, IDragHandler {

    public GameObject pivot;
    public int speed = 200;

    public void OnDrag(PointerEventData eventData)
    {
        eventData.selectedObject.transform.RotateAround(pivot.transform.position, Vector3.forward, speed * Time.deltaTime);


        Debug.Log("isDraging");
    }
}
