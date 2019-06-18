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
        private GameObject canvas;
        private GameObject button;
        private ButtonDynamicEventProcessor _buttonDynamicEventProcessor;
        private ControllerResolver _controllerResolver = new ControllerResolver(Ui.GetControllerRegistry(),new ControllerFactory()); 
         
        public CanvasButtonsBuilder(GameObject canvas) : base(canvas)
        {
            this.canvas = canvas;
            this.button = Object.Instantiate(Resources.Load<GameObject>("Button"));
            _buttonDynamicEventProcessor = new ButtonDynamicEventProcessor(new ClickActionFactory());
            this.button.transform.parent = this.canvas.transform;
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
        public CanvasButtonsBuilder Click<T,T2> (string controllerName,string methodName, T testVal,T2 testVal2)
        {
            var controller = _controllerResolver.Resolve(controllerName);
            _buttonDynamicEventProcessor.process(this.button,controller,methodName,testVal,testVal2);
            return this;
        }
        
        public CanvasButtonsBuilder Hover (string controllerName,string methodName)
        {
            this.button.AddComponent<HoverableAction>();
            return this;
        }
        
        public CanvasButtonsBuilder RemoveCanvases (int level)
        {
            var controllerRegistry = Ui.GetControllerRegistry();
            this.button.AddComponent<RemoveCanvasAction>().Level = level;
            this.button.GetComponent<RemoveCanvasAction>().removeEvent.AddListener(_controllerResolver.Resolve("Project.Test.RemoveCanvasController").GetComponent<RemoveCanvasController>().RemoveCanvases);
            return this;
        }
    }
}