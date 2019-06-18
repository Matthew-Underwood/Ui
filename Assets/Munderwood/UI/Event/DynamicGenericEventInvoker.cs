using System;
using System.Reflection;
using Munderwood.UI.Event.Click;
using UnityEngine;
using UnityEngine.Events;

namespace Munderwood.UI.Event
{
    public class DynamicGenericEventInvoker
    {
        public object GenericInstance { get; set; }
        public int ArgumentCount { get; set; }

        public void GenericEventFactory(object[] arguments)
        {
            ArgumentCount = arguments.Length;
            Type genericType = GetGenericDefinitionTypeFromArguments();
            Type[] typeArguments = GetTypeArguments(arguments);
            Type  constructedGenericType =  genericType.MakeGenericType(typeArguments);
            GenericInstance = Activator.CreateInstance(constructedGenericType);
        }
    
        public void AddListener <T,T2>(GameObject controller ,string methodName, T testVal, T2 testVal2)
        {
            Type controllerType = Type.GetType(controller.name);
            MethodInfo controllerMethod = controllerType.GetMethod(methodName);
            switch (ArgumentCount)
            {
                case 1:
                    EventInfo eventInfo = GenericInstance.GetType().GetEvent();
                    UnityAction<int> action = (a) => controllerMethod.Invoke(controller.GetComponent(controllerType),new object[] {a});
                    GenericInstance.GetType().GetMethod("AddListener").Invoke(GenericInstance, new object[] {});
                    /*GenericInstance.GetType().GetMethod("AddListener").Invoke(GenericInstance, new object[] {
                    (a) => controllerMethod.Invoke(controller.GetComponent(controllerType),new object[] {a}) });
                    buttonComponent.clickEventTwoArgs.AddListener((a,b) => 
                        controllerMethod.Invoke(controller.GetComponent(controllerType),
                            new object[] {a,b}));*/
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }
        

        protected Type GetGenericDefinitionTypeFromArguments()
        {
            Type genericType = null;
            switch (ArgumentCount)
            {
                case 1:
                    genericType = typeof(ClickEvent<>);
                    break;
                case 2:
                    genericType = typeof(ClickEvent<,>);
                    break;
                case 3:
                    genericType = typeof(ClickEvent<,,>);
                    break;
                case 4:
                    genericType = typeof(ClickEvent<,,,>);
                    break;
            }
            return genericType;
        }

        protected Type[] GetTypeArguments(object[] arguments)
        {
            Type[] typeArgs = null;
            switch (ArgumentCount)
            {
                case 1:
                    typeArgs = new[] {arguments[0].GetType()};
                    break;
                case 2:
                    typeArgs = new[] {arguments[0].GetType(),arguments[1].GetType()};
                    break;
                case 3:
                    typeArgs = new[] {arguments[0].GetType(),arguments[1].GetType(),arguments[2].GetType()};
                    break;
                case 4:
                    typeArgs = new[] {arguments[0].GetType(),arguments[1].GetType(),arguments[2].GetType(),arguments[3].GetType()};
                    break;
            }

            return typeArgs;
        }
        
    }

}