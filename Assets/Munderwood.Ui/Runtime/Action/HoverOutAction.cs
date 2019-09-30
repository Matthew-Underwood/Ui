using Boo.Lang.Runtime;
using Munderwood.Events;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Munderwood.UI.Action
{
    public class HoverOutAction : MonoBehaviour, IPointerExitHandler, IEventInvoker
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
        
        public void OnPointerExit(PointerEventData eventData)
        {
            if (_eventManager != null && _pointerDataEventManager != null)
            {
                _pointerDataEventManager.AddListener(eventData);
                _pointerDataEventManager.AssignValues(eventData);
                _pointerDataEventManager.Invoke();
                _eventManager.Invoke();
            }
            else
            {
                //throw new RuntimeException("No event setup with this " + this.name);
            }
        }
    }
}

