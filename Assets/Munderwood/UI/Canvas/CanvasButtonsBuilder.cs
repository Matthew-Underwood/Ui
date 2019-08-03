using System;
using System.Reflection;
using Munderwood.UI.Action;
using Munderwood.UI.Controller;
using Munderwood.UI.Event;
using Project.Test;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace Munderwood.UI.Canvas
{
    public class CanvasButtonsBuilder : CanvasBuilder
    {
        private readonly GameObject button;
        private ButtonDynamicEventProcessor _buttonDynamicEventProcessor;

        public CanvasButtonsBuilder(GameObject canvas,ControllerResolver controllerResolver) : base(canvas,controllerResolver)
        {
            this.canvas = canvas;
            this.controllerResolver = controllerResolver;
            this.button = Object.Instantiate(Resources.Load<GameObject>("Button"));
            this.button.transform.SetParent(this.canvas.transform,false);
        }
        
        public ButtonEventBuilder Event {
            get
            {
                return new ButtonEventBuilder(this.canvas,this.controllerResolver,this.button);
            }
        } 
        
        public CanvasButtonsBuilder Text (string text)
        {
            Text textComponent = this.button.transform.Find("Text").GetComponent<Text>();
            textComponent.text = text;
            return this;
        }
        
        public CanvasButtonsBuilder Position (int x, int y)
        {
            this.button.GetComponent<RectTransform>().anchoredPosition = new Vector3(x,y,0.0f);
            return this;
        }
        
        public CanvasButtonsBuilder Size (int width, int height)
        {
            this.button.GetComponent<RectTransform>().sizeDelta = new Vector2(width,height);
            return this;
        }
    }
}