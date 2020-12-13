using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GasButton : Button
{
    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        CarController.verticalInput = 1;
        Debug.Log("Down");
        //show text
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);
        CarController.verticalInput = 0;
        Debug.Log("Up");
        //hide text
    }
}
