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
        private readonly ButtonDynamicEventProcessor buttonDynamicEventProcessor;
        private readonly ButtonDynamicEventHoverProcessor buttonDynamicEventHoverProcessor;

        public ButtonEventBuilder(GameObject canvas,ControllerResolver controllerResolver,GameObject button) : base(canvas,controllerResolver)
        {
            this.button = button;
            this.buttonActionFactory = new ButtonActionFactory(button);
            this.buttonDynamicEventProcessor = new ButtonDynamicEventProcessor();
            this.buttonDynamicEventHoverProcessor = new ButtonDynamicEventHoverProcessor();
        }
        public ButtonEventBuilder Click (string controllerName,string methodName)
        {
            
            var controller = this.controllerResolver.Resolve(controllerName);
            
            buttonDynamicEventProcessor.process(buttonActionFactory.CreateClickAction(),controller,methodName);
            return this;
        }
        
        public ButtonEventBuilder Click<T> (string controllerName,string methodName, T testVal)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            
            buttonDynamicEventProcessor.process(buttonActionFactory.CreateClickAction(),controller,methodName,testVal);
            return this;
        }
        
        public ButtonEventBuilder Click<T,T2> (string controllerName,string methodName, T testVal,T2 testVal2)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            
            buttonDynamicEventProcessor.process(buttonActionFactory.CreateClickAction(),controller,methodName,testVal,testVal2);
            return this;
        }
        
        public ButtonEventBuilder Click<T,T2,T3> (string controllerName,string methodName, T testVal,T2 testVal2,T3 testVal3)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            
            buttonDynamicEventProcessor.process(buttonActionFactory.CreateClickAction(),controller,methodName,testVal,testVal2,testVal3);
            return this;
        }
        
        public ButtonEventBuilder Click<T,T2,T3,T4> (string controllerName,string methodName, T testVal,T2 testVal2,T3 testVal3,T4 testVal4)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            
            buttonDynamicEventProcessor.process(buttonActionFactory.CreateClickAction(),controller,methodName,testVal,testVal2,testVal3,testVal4);
            return this;
        }
        
        public ButtonEventBuilder Hover (string controllerName,string methodName)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            
            buttonDynamicEventHoverProcessor.process(buttonActionFactory.CreateHoverAction(),controller,methodName);
            return this;
        }
        
        public ButtonEventBuilder Hover<T> (string controllerName,string methodName, T testVal)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            
            buttonDynamicEventHoverProcessor.process(buttonActionFactory.CreateHoverAction(),controller,methodName,testVal);
            return this;
        }
        
        public ButtonEventBuilder Hover<T,T2> (string controllerName,string methodName, T testVal,T2 testVal2)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            
            buttonDynamicEventHoverProcessor.process(buttonActionFactory.CreateHoverAction(),controller,methodName,testVal,testVal2);
            return this;
        }
        
        public ButtonEventBuilder Hover<T,T2,T3> (string controllerName,string methodName, T testVal,T2 testVal2,T3 testVal3)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            
            buttonDynamicEventHoverProcessor.process(buttonActionFactory.CreateHoverAction(),controller,methodName,testVal,testVal2,testVal3);
            return this;
        }
        
        public ButtonEventBuilder Hover<T,T2,T3,T4> (string controllerName,string methodName, T testVal,T2 testVal2,T3 testVal3,T4 testVal4)
        {
            var controller = this.controllerResolver.Resolve(controllerName);
            
            buttonDynamicEventHoverProcessor.process(buttonActionFactory.CreateHoverAction(),controller,methodName,testVal,testVal2,testVal3,testVal4);
            return this;
        }
    }
}