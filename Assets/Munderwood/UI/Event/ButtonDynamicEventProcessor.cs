using System;
using System.Reflection;
using Munderwood.UI.Action;
using Munderwood.UI.Controller;
using Munderwood.UI.Event.Click;
using UnityEngine;
using UnityEngine.Events;
using Object = System.Object;

namespace Munderwood.UI.Event
{
    public class ButtonDynamicEventProcessor
    {
        private readonly ClickActionFactory _clickActionFactory;

        public ButtonDynamicEventProcessor (ClickActionFactory clickActionFactory)
        {
            _clickActionFactory = clickActionFactory;
        }
        public void process <T, T2>(GameObject button , GameObject controller, string controllerMethodName, T testVal, T2 testVal2)
        {
            Action.ClickAction buttonComponent = _clickActionFactory.Create(button);
            
            Type controllerType = Type.GetType(controller.name);
            MethodInfo controllerMethod = controllerType.GetMethod(controllerMethodName);
            
            buttonComponent.DynamicGenericEventInvoker = new DynamicGenericEventInvoker();
            buttonComponent.DynamicGenericEventInvoker.AddListener(controller,controllerMethod.Name,testVal,testVal2);
            
        }
    }
}