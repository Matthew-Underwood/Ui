using Boo.Lang.Runtime;
using Munderwood.UI.Event;
using Munderwood.UI.Event.Click;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class ClickAction : MonoBehaviour , IPointerUpHandler
{
    public DynamicGenericEventInvoker DynamicGenericEventInvoker;
    public void OnPointerUp(PointerEventData eventData)
    {
        DynamicGenericEventInvoker.Invoke();
    }
}

