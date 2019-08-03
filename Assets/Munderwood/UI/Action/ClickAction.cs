using System;
using Boo.Lang.Runtime;
using Munderwood.UI.Event;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Munderwood.UI.Action
{
    public class ClickAction : MonoBehaviour, IPointerUpHandler, IEventInvoker
    {
        private DynamicGenericEventInvoker DynamicGenericEventInvoker;

        public void SetEventInvoker (DynamicGenericEventInvoker eventInvoker)
        {
            DynamicGenericEventInvoker = eventInvoker;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (DynamicGenericEventInvoker != null)
            {
                DynamicGenericEventInvoker.Invoke();
            }
            else
            {
                throw new RuntimeException("No event setup with this " + this.name);
            }
        }
    }
}

