using System;
using Munderwood.Events;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Munderwood.UI.Action
{
    public class ClickAction : MonoBehaviour, IPointerUpHandler, IEventInvoker
    {
        private EventManager _eventManager;
        private PointerDataEventManager _pointerDataEventManager;
        
        public void SetEventInvoker(EventManager eventManager)
        {
            _eventManager = eventManager;
        }
        public void SetPointerDataEventInvoker(PointerDataEventManager pointerDataEventManager)
        {
            _pointerDataEventManager = pointerDataEventManager;
        }
        
        public void OnPointerUp(PointerEventData eventData)
        {
            if (_eventManager != null && _pointerDataEventManager != null)
            {
                _eventManager.Invoke();
                _pointerDataEventManager.AddListener(eventData);
                _pointerDataEventManager.AssignValues(eventData);
                _pointerDataEventManager.Invoke();
            }
            else
            {
                //throw new RuntimeException("No event setup with this " + this.name);
            }
        }
    }
}

