using System;
using System.Reflection;
using UnityEngine;

namespace Munderwood.UI.Event
{
    public class ButtonDynamicEventHoverProcessor
    {
        public void process (IEventInvoker buttonComponent , GameObject controller, string controllerMethodName)
        {
            Type controllerType = Type.GetType(controller.name);
            MethodInfo controllerMethod = controllerType.GetMethod(controllerMethodName);
            
            DynamicGenericEventInvoker dynamicGenericEventInvoker = new DynamicGenericEventInvoker();
            dynamicGenericEventInvoker.AddListener(controller,controllerMethod.Name);
            buttonComponent.SetEventInvoker(dynamicGenericEventInvoker);
        }
        public void process <T>(IEventInvoker buttonComponent , GameObject controller, string controllerMethodName, T testVal)
        {
            Type controllerType = Type.GetType(controller.name);
            MethodInfo controllerMethod = controllerType.GetMethod(controllerMethodName);
            
            DynamicGenericEventInvoker dynamicGenericEventInvoker = new DynamicGenericEventInvoker();
            dynamicGenericEventInvoker.AddListener(controller,controllerMethod.Name,testVal);
            buttonComponent.SetEventInvoker(dynamicGenericEventInvoker);
        }
        public void process <T, T2>(IEventInvoker buttonComponent , GameObject controller, string controllerMethodName, T testVal, T2 testVal2)
        {
            Type controllerType = Type.GetType(controller.name);
            MethodInfo controllerMethod = controllerType.GetMethod(controllerMethodName);
            
            DynamicGenericEventInvoker dynamicGenericEventInvoker = new DynamicGenericEventInvoker();
            dynamicGenericEventInvoker.AddListener(controller,controllerMethod.Name,testVal,testVal2);
            buttonComponent.SetEventInvoker(dynamicGenericEventInvoker);
        }
        public void process <T, T2, T3>(IEventInvoker buttonComponent , GameObject controller, string controllerMethodName, T testVal, T2 testVal2, T3 testVal3)
        {
            Type controllerType = Type.GetType(controller.name);
            MethodInfo controllerMethod = controllerType.GetMethod(controllerMethodName);
            
            DynamicGenericEventInvoker dynamicGenericEventInvoker = new DynamicGenericEventInvoker();
            dynamicGenericEventInvoker.AddListener(controller,controllerMethod.Name,testVal,testVal2,testVal3);
            buttonComponent.SetEventInvoker(dynamicGenericEventInvoker);
        }
        public void process <T, T2, T3, T4>(IEventInvoker buttonComponent , GameObject controller, string controllerMethodName, T testVal, T2 testVal2, T3 testVal3, T4 testVal4)
        {
            Type controllerType = Type.GetType(controller.name);
            MethodInfo controllerMethod = controllerType.GetMethod(controllerMethodName);
            
            DynamicGenericEventInvoker dynamicGenericEventInvoker = new DynamicGenericEventInvoker();
            dynamicGenericEventInvoker.AddListener(controller,controllerMethod.Name,testVal,testVal2,testVal3,testVal4);
            buttonComponent.SetEventInvoker(dynamicGenericEventInvoker);
        }

    }
}