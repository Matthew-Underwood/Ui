using System;
using Boo.Lang.Runtime;
using Munderwood.UI.Event;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Munderwood.UI.Action
{
    public class ClickAction : MonoBehaviour, IPointerUpHandler
    {
        public DynamicGenericEventInvoker DynamicGenericEventInvoker;

        public void OnPointerUp(PointerEventData eventData)
        {
            if (DynamicGenericEventInvoker != null)
            {
                Type type = DynamicGenericEventInvoker.GetType();
                Debug.Log(type.ToString());
            }
            else
            {
                throw new RuntimeException("No event setup with this " + this.name);
            }
        }
    }
}

