using Munderwood.UI.Action;
using Munderwood.UI.Controller;
using Munderwood.UI.Event;
using UnityEngine;

namespace Munderwood.UI.Canvas
{
    public class ButtonEventBuilder : CanvasBuilder
    {
        private readonly GameObject button;
        private readonly ButtonActionFactory buttonActionFactory;

        public ButtonEventBuilder(GameObject canvas,ControllerResolver controllerResolver,GameObject button) : base(canvas,controllerResolver)
        {
            this.button = button;
            this.buttonActionFactory = new ButtonActionFactory(button);
            
        }
        public ButtonEventBuilder Click (string controllerName,string methodName)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            IEventInvoker button = buttonActionFactory.CreateClickAction();
            EventManager eventManager = new EventManager(controller,methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,"SetPointerEventData");
            eventManager.AddListener();
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder Click<T> (string controllerName,string methodName, T val)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            IEventInvoker button = buttonActionFactory.CreateClickAction();
            EventManager eventManager = new EventManager(controller,methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,"SetPointerEventData");
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
            EventManager eventManager = new EventManager(controller,methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,"SetPointerEventData");
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
            EventManager eventManager = new EventManager(controller,methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,"SetPointerEventData");
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
            EventManager eventManager = new EventManager(controller,methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,"SetPointerEventData");
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
            EventManager eventManager = new EventManager(controller,methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,"SetPointerEventData");
            eventManager.AddListener();
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder HoverIn<T> (string controllerName,string methodName, T val)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            IEventInvoker button = buttonActionFactory.CreateHoverInAction();
            EventManager eventManager = new EventManager(controller,methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,"SetPointerEventData");
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
            EventManager eventManager = new EventManager(controller,methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,"SetPointerEventData");
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
            EventManager eventManager = new EventManager(controller,methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,"SetPointerEventData");
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
            EventManager eventManager = new EventManager(controller,methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,"SetPointerEventData");
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
            EventManager eventManager = new EventManager(controller,methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,"SetPointerEventData");
            eventManager.AddListener();
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
        
        public ButtonEventBuilder HoverOut<T> (string controllerName,string methodName, T val)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            IEventInvoker button = buttonActionFactory.CreateHoverOutAction();
            EventManager eventManager = new EventManager(controller,methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,"SetPointerEventData");
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
            EventManager eventManager = new EventManager(controller,methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,"SetPointerEventData");
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
            EventManager eventManager = new EventManager(controller,methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,"SetPointerEventData");
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
            EventManager eventManager = new EventManager(controller,methodName);
            PointerDataEventManager pointerDataEventManager = new PointerDataEventManager(controller,"SetPointerEventData");
            eventManager.AddListener(val,val2,val3,val4);
            eventManager.AssignValues(val,val2,val3,val4);
            button.SetEventInvoker(eventManager);
            button.SetPointerDataEventInvoker(pointerDataEventManager);
            return this;
        }
    }
}