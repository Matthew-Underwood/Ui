using System;
using Boo.Lang.Runtime;
using Munderwood.UI.Event;
using UnityEditor;
using UnityEditor.Experimental.TerrainAPI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Munderwood.UI.Action
{
    public class HoverAction : MonoBehaviour, IPointerEnterHandler, IEventInvoker
    {
        private DynamicGenericEventInvoker DynamicGenericEventInvoker;
        private Vector2 mousePos;
        private Vector2 anchoredPos;
        private Vector2 anchoredPos2;
        private Vector2 localRectPos;

        public void SetEventInvoker (DynamicGenericEventInvoker eventInvoker)
        {
            DynamicGenericEventInvoker = eventInvoker;
        }

        public void OnPointerEnter(PointerEventData eventData)
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

        public void Update()
        {
            mousePos = Input.mousePosition;

            GameObject masterCanvas = GameObject.Find("masterCanvas");
            GameObject canvasOne = GameObject.Find("Test canvas 1");
            anchoredPos = masterCanvas.GetComponent<RectTransform>().anchoredPosition;
            anchoredPos2 = canvasOne.GetComponent<RectTransform>().anchoredPosition;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(masterCanvas.GetComponent<RectTransform>(),mousePos,null, out localRectPos);
        }

        public void OnGUI()
        {
            //Vector2 convertedPos =  anchoredPos - localRectPos;
            Vector2 convertedPos = new Vector2(anchoredPos.x + localRectPos.x,localRectPos.y - anchoredPos.y);
            GUI.Label(new Rect(10, 480, 200, 20),"Mouse: " + mousePos.ToString());
            GUI.Label(new Rect(10, 500, 200, 20),"Anch: " + anchoredPos.ToString());
            GUI.Label(new Rect(10, 520, 200, 20),"Anch2: " + anchoredPos2.ToString());
            GUI.Label(new Rect(10, 540, 200, 20),"Local: " + localRectPos.ToString());
            GUI.Label(new Rect(10, 560, 200, 20),"Con: " + convertedPos.ToString());
        }
    }
}

