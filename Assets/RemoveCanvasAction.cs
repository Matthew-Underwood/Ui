using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


[System.Serializable]
public class RemoveCanvasesEvent : UnityEvent<int>
{
}

public class RemoveCanvasAction : MonoBehaviour , IPointerUpHandler
{
    public int Level { get; set;}
    public RemoveCanvasesEvent removeEvent = new RemoveCanvasesEvent();


    public void OnPointerUp(PointerEventData eventData)
    {
        removeEvent.Invoke(this.Level);
    }
}