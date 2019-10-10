using System;
using Munderwood.Events;
using Munderwood.Ui.Action;
using Munderwood.Ui.Canvas;
using Munderwood.Ui.Canvas.Builder;
using Munderwood.Ui.Controller;
using UnityEngine;

namespace Munderwood.Ui.Button
{
    public class ButtonEventBuilder : CanvasBuilder
    {
        private readonly GameObject button;
        private readonly ButtonActionFactory buttonActionFactory;
        protected Type controllerType;

        protected Type ControllerType
        {
            get => controllerType;
            set => controllerType = value;
        }

        public ButtonEventBuilder(GameObject canvas,ControllerResolver controllerResolver,CanvasDimensionsTransformer canvasDimensionsTransformer,GameObject button) : base(canvas,controllerResolver,canvasDimensionsTransformer)
        {
            this.button = button;
            this.buttonActionFactory = new ButtonActionFactory(button);
            
        }
        public ButtonEventBuilder Click (string controllerName,string methodName)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            IEventInvoker button = buttonActionFactory.CreateClickAction();
            EventManager eventManager = new EventManager(controller, Type.GetType(controllerName), methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,Type.GetType(controllerName), "SetPointerEventData");
            eventManager.AddListener();
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder Click<T> (string controllerName,string methodName, T val)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            IEventInvoker button = buttonActionFactory.CreateClickAction();
            EventManager eventManager = new EventManager(controller, Type.GetType(controllerName), methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,Type.GetType(controllerName), "SetPointerEventData");
            eventManager.AddListener(val);
            eventManager.AssignValues(val);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder Click<T,T2> (string controllerName,string methodName, T val,T2 val2)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            IEventInvoker button = buttonActionFactory.CreateClickAction();
            EventManager eventManager = new EventManager(controller, Type.GetType(controllerName), methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,Type.GetType(controllerName), "SetPointerEventData");
            eventManager.AddListener(val,val2);
            eventManager.AssignValues(val,val2);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder Click<T,T2,T3> (string controllerName,string methodName, T val,T2 val2,T3 val3)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            IEventInvoker button = buttonActionFactory.CreateClickAction();
            EventManager eventManager = new EventManager(controller, Type.GetType(controllerName), methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,Type.GetType(controllerName), "SetPointerEventData");
            eventManager.AddListener(val,val2,val3);
            eventManager.AssignValues(val,val2,val3);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder Click<T,T2,T3,T4> (string controllerName,string methodName, T val,T2 val2,T3 val3,T4 val4)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            IEventInvoker button = buttonActionFactory.CreateClickAction();
            EventManager eventManager = new EventManager(controller, Type.GetType(controllerName), methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,Type.GetType(controllerName), "SetPointerEventData");
            eventManager.AddListener(val,val2,val3,val4);
            eventManager.AssignValues(val,val2,val3,val4);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder HoverIn (string controllerName,string methodName)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            IEventInvoker button = buttonActionFactory.CreateHoverInAction();
            EventManager eventManager = new EventManager(controller, Type.GetType(controllerName), methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,Type.GetType(controllerName), "SetPointerEventData");
            eventManager.AddListener();
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder HoverIn<T> (string controllerName,string methodName, T val)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            IEventInvoker button = buttonActionFactory.CreateHoverInAction();
            EventManager eventManager = new EventManager(controller, Type.GetType(controllerName), methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,Type.GetType(controllerName), "SetPointerEventData");
            eventManager.AddListener(val);
            eventManager.AssignValues(val);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder HoverIn<T,T2> (string controllerName,string methodName, T val,T2 val2)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            IEventInvoker button = buttonActionFactory.CreateHoverInAction();
            EventManager eventManager = new EventManager(controller, Type.GetType(controllerName), methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,Type.GetType(controllerName), "SetPointerEventData");
            eventManager.AddListener(val,val2);
            eventManager.AssignValues(val,val2);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder HoverIn<T,T2,T3> (string controllerName,string methodName, T val,T2 val2,T3 val3)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            IEventInvoker button = buttonActionFactory.CreateHoverInAction();
            EventManager eventManager = new EventManager(controller, Type.GetType(controllerName), methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,Type.GetType(controllerName), "SetPointerEventData");
            eventManager.AddListener(val,val2,val3);
            eventManager.AssignValues(val,val2,val3);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder HoverIn<T,T2,T3,T4> (string controllerName,string methodName, T val,T2 val2,T3 val3,T4 val4)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            IEventInvoker button = buttonActionFactory.CreateHoverInAction();
            EventManager eventManager = new EventManager(controller, Type.GetType(controllerName), methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,Type.GetType(controllerName), "SetPointerEventData");
            eventManager.AddListener(val,val2,val3,val4);
            eventManager.AssignValues(val,val2,val3,val4);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        public ButtonEventBuilder HoverOut (string controllerName,string methodName)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            IEventInvoker button = buttonActionFactory.CreateHoverOutAction();
            EventManager eventManager = new EventManager(controller, Type.GetType(controllerName), methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,Type.GetType(controllerName), "SetPointerEventData");
            eventManager.AddListener();
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder HoverOut<T> (string controllerName,string methodName, T val)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            IEventInvoker button = buttonActionFactory.CreateHoverOutAction();
            EventManager eventManager = new EventManager(controller, Type.GetType(controllerName), methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,Type.GetType(controllerName), "SetPointerEventData");
            eventManager.AddListener(val);
            eventManager.AssignValues(val);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder HoverOut<T,T2> (string controllerName,string methodName, T val,T2 val2)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            IEventInvoker button = buttonActionFactory.CreateHoverOutAction();
            EventManager eventManager = new EventManager(controller, Type.GetType(controllerName), methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,Type.GetType(controllerName), "SetPointerEventData");
            eventManager.AddListener(val,val2);
            eventManager.AssignValues(val,val2);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder HoverOut<T,T2,T3> (string controllerName,string methodName, T val,T2 val2,T3 val3)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            IEventInvoker button = buttonActionFactory.CreateHoverOutAction();
            EventManager eventManager = new EventManager(controller, Type.GetType(controllerName), methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,Type.GetType(controllerName), "SetPointerEventData");
            eventManager.AddListener(val,val2,val3);
            eventManager.AssignValues(val,val2,val3);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder HoverOut<T,T2,T3,T4> (string controllerName,string methodName, T val,T2 val2,T3 val3,T4 val4)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            IEventInvoker button = buttonActionFactory.CreateHoverOutAction();
            EventManager eventManager = new EventManager(controller, Type.GetType(controllerName), methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,Type.GetType(controllerName), "SetPointerEventData");
            eventManager.AddListener(val,val2,val3,val4);
            eventManager.AssignValues(val,val2,val3,val4);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
    }
}