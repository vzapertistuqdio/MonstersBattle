using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PointerEnter : MonoBehaviour, IDropHandler
{
    [SerializeField] private Text energyText;
    public static int currentEnergy = 75;
    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag!=null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().position = GetComponent<RectTransform>().position;
            eventData.pointerDrag.GetComponent<RectTransform>().localScale = Vector3.one;
            currentEnergy -= 15;
            energyText.text = currentEnergy.ToString() + "/75";
        }
    }
}
