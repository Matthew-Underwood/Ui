using Munderwood.Events;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Munderwood.Ui.Action
{
    public class HoverInAction : MonoBehaviour, IPointerEnterHandler, IEventInvoker
    {
        private EventManager _eventManager;
        private PointerDataEventManager _pointerDataEventManager;
        private Vector2 canvasPos;
        private Vector2 canvasData;
        private Vector2 transformData;
        
        public void SetEventInvoker(EventManager eventManager)
        {
            _eventManager = eventManager;
        }
        
        public void SetPointerDataEventInvoker(PointerDataEventManager pointerDataEventManager)
        {
            _pointerDataEventManager = pointerDataEventManager;
        }
        
        public void OnPointerEnter(PointerEventData eventData)
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
                // TODO change exception 
                //throw new RuntimeException("No event setup with this " + this.name);
            }
        }

        public void Update()
        {
            GameObject testCanvas = GameObject.Find("parent");
            canvasPos = CoordinateTransform.ParentCanvasTransform(new Vector2(Input.mousePosition.x,Input.mousePosition.y),new Vector2(0,0));
            testCanvas.GetComponent<RectTransform>().anchoredPosition = canvasPos;
        }

        private void OnGUI()
        {
            GUI.TextField(new Rect(20, 100, 200, 50), "oob x " + transformData.x + " y " + transformData.y);
            GUI.Box(new Rect(canvasPos.x, canvasPos.y, 200, 400), "This is a box");
        }
    }
}

