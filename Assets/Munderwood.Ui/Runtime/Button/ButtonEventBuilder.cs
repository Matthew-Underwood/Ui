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
        public ButtonEventBuilder Click (Type controllerType,string methodName)
        {
            var controller = this.controllerResolver.Resolve(controllerType);
            IEventInvoker button = buttonActionFactory.CreateClickAction();
            EventManager eventManager = new EventManager(controller, controllerType, methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,controllerType, "SetPointerEventData");
            eventManager.AddListener();
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder Click<T> (Type controllerType,string methodName, T val)
        {
            var controller = this.controllerResolver.Resolve(controllerType);
            IEventInvoker button = buttonActionFactory.CreateClickAction();
            EventManager eventManager = new EventManager(controller, controllerType, methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,controllerType, "SetPointerEventData");
            eventManager.AddListener(val);
            eventManager.AssignValues(val);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder Click<T,T2> (Type controllerType,string methodName, T val,T2 val2)
        {
            var controller = this.controllerResolver.Resolve(controllerType);
            IEventInvoker button = buttonActionFactory.CreateClickAction();
            EventManager eventManager = new EventManager(controller, controllerType, methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,controllerType, "SetPointerEventData");
            eventManager.AddListener(val,val2);
            eventManager.AssignValues(val,val2);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder Click<T,T2,T3> (Type controllerType,string methodName, T val,T2 val2,T3 val3)
        {
            var controller = this.controllerResolver.Resolve(controllerType);
            IEventInvoker button = buttonActionFactory.CreateClickAction();
            EventManager eventManager = new EventManager(controller, controllerType, methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,controllerType, "SetPointerEventData");
            eventManager.AddListener(val,val2,val3);
            eventManager.AssignValues(val,val2,val3);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder Click<T,T2,T3,T4> (Type controllerType,string methodName, T val,T2 val2,T3 val3,T4 val4)
        {
            var controller = this.controllerResolver.Resolve(controllerType);
            IEventInvoker button = buttonActionFactory.CreateClickAction();
            EventManager eventManager = new EventManager(controller, controllerType, methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,controllerType, "SetPointerEventData");
            eventManager.AddListener(val,val2,val3,val4);
            eventManager.AssignValues(val,val2,val3,val4);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder HoverIn (Type controllerType,string methodName)
        {
            var controller = this.controllerResolver.Resolve(controllerType);
            IEventInvoker button = buttonActionFactory.CreateHoverInAction();
            EventManager eventManager = new EventManager(controller, controllerType, methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,controllerType, "SetPointerEventData");
            eventManager.AddListener();
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder HoverIn<T> (Type controllerType,string methodName, T val)
        {
            var controller = this.controllerResolver.Resolve(controllerType);
            IEventInvoker button = buttonActionFactory.CreateHoverInAction();
            EventManager eventManager = new EventManager(controller, controllerType, methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,controllerType, "SetPointerEventData");
            eventManager.AddListener(val);
            eventManager.AssignValues(val);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder HoverIn<T,T2> (Type controllerType,string methodName, T val,T2 val2)
        {
            var controller = this.controllerResolver.Resolve(controllerType);
            IEventInvoker button = buttonActionFactory.CreateHoverInAction();
            EventManager eventManager = new EventManager(controller, controllerType, methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,controllerType, "SetPointerEventData");
            eventManager.AddListener(val,val2);
            eventManager.AssignValues(val,val2);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder HoverIn<T,T2,T3> (Type controllerType,string methodName, T val,T2 val2,T3 val3)
        {
            var controller = this.controllerResolver.Resolve(controllerType);
            IEventInvoker button = buttonActionFactory.CreateHoverInAction();
            EventManager eventManager = new EventManager(controller, controllerType, methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,controllerType, "SetPointerEventData");
            eventManager.AddListener(val,val2,val3);
            eventManager.AssignValues(val,val2,val3);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder HoverIn<T,T2,T3,T4> (Type controllerType,string methodName, T val,T2 val2,T3 val3,T4 val4)
        {
            var controller = this.controllerResolver.Resolve(controllerType);
            IEventInvoker button = buttonActionFactory.CreateHoverInAction();
            EventManager eventManager = new EventManager(controller, controllerType, methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,controllerType, "SetPointerEventData");
            eventManager.AddListener(val,val2,val3,val4);
            eventManager.AssignValues(val,val2,val3,val4);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        public ButtonEventBuilder HoverOut (Type controllerType,string methodName)
        {
            var controller = this.controllerResolver.Resolve(controllerType);
            IEventInvoker button = buttonActionFactory.CreateHoverOutAction();
            EventManager eventManager = new EventManager(controller, controllerType, methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,controllerType, "SetPointerEventData");
            eventManager.AddListener();
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder HoverOut<T> (Type controllerType,string methodName, T val)
        {
            var controller = this.controllerResolver.Resolve(controllerType);
            IEventInvoker button = buttonActionFactory.CreateHoverOutAction();
            EventManager eventManager = new EventManager(controller, controllerType, methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,controllerType, "SetPointerEventData");
            eventManager.AddListener(val);
            eventManager.AssignValues(val);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder HoverOut<T,T2> (Type controllerType,string methodName, T val,T2 val2)
        {
            var controller = this.controllerResolver.Resolve(controllerType);
            IEventInvoker button = buttonActionFactory.CreateHoverOutAction();
            EventManager eventManager = new EventManager(controller, controllerType, methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,controllerType, "SetPointerEventData");
            eventManager.AddListener(val,val2);
            eventManager.AssignValues(val,val2);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder HoverOut<T,T2,T3> (Type controllerType,string methodName, T val,T2 val2,T3 val3)
        {
            var controller = this.controllerResolver.Resolve(controllerType);
            IEventInvoker button = buttonActionFactory.CreateHoverOutAction();
            EventManager eventManager = new EventManager(controller, controllerType, methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,controllerType, "SetPointerEventData");
            eventManager.AddListener(val,val2,val3);
            eventManager.AssignValues(val,val2,val3);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder HoverOut<T,T2,T3,T4> (Type controllerType,string methodName, T val,T2 val2,T3 val3,T4 val4)
        {
            var controller = this.controllerResolver.Resolve(controllerType);
            IEventInvoker button = buttonActionFactory.CreateHoverOutAction();
            EventManager eventManager = new EventManager(controller, controllerType, methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,controllerType, "SetPointerEventData");
            eventManager.AddListener(val,val2,val3,val4);
            eventManager.AssignValues(val,val2,val3,val4);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
    }
}