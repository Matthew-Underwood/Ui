using System;
using System.Reflection;
using Munderwood.UI.Controller;
using Munderwood.UI.Event.Click;
using Project.Test;
using UnityEngine;
using UnityEngine.Events;

namespace Munderwood.UI.Event
{
    public class DynamicGenericEventInvoker
    {
        private UnityEvent _clickEvent;
        private IEventOneArg _clickEventOneArg;
        private IEventTwoArgs _clickEventTwoArgs;
        private IEventThreeArgs _clickEventThreeArgs;
        private IEventFourArgs _clickEventFourArgs;
        private object[] arguments;
        
        public void AddListener (GameObject controller ,string methodName)
        {
            Type controllerType = Type.GetType(controller.name);
            MethodInfo controllerMethod = controllerType.GetMethod(methodName);
            UnityEvent eventClick = new UnityEvent();
            eventClick.AddListener(
                () => { controllerMethod.Invoke(controller.GetComponent(controllerType), new object[] {});
                });
            arguments = new object[] {};
            _clickEvent = eventClick;
        }
        
        public void AddListener <T>(GameObject controller ,string methodName, T testVal)
        {
            Type controllerType = Type.GetType(controller.name);
            MethodInfo controllerMethod = controllerType.GetMethod(methodName);
            ClickEvent<T> eventClick = new ClickEvent<T>();
            eventClick.AddListener(
                (T a) => { controllerMethod.Invoke(controller.GetComponent(controllerType), new object[] {a});
                });
            arguments = new object[] {testVal};
            _clickEventOneArg = eventClick;
        }
        
        public void AddListener <T,T2>(GameObject controller ,string methodName, T testVal, T2 testVal2)
        {
            Type controllerType = Type.GetType(controller.name);
            MethodInfo controllerMethod = controllerType.GetMethod(methodName);
            ClickEvent<T,T2> eventClick = new ClickEvent<T, T2>();
            eventClick.AddListener(
                (T a, T2 b) => { controllerMethod.Invoke(controller.GetComponent(controllerType), new object[] {a, b});
                });
            arguments = new object[] {testVal,testVal2};
            _clickEventTwoArgs = eventClick;
        }
        
        public void AddListener <T,T2,T3>(GameObject controller ,string methodName, T testVal, T2 testVal2, T3 testVal3)
        {
            Type controllerType = Type.GetType(controller.name);
            MethodInfo controllerMethod = controllerType.GetMethod(methodName);
            ClickEvent<T,T2, T3> eventClick = new ClickEvent<T, T2, T3>();
            eventClick.AddListener(
                (T a, T2 b, T3 c) => { controllerMethod.Invoke(controller.GetComponent(controllerType), new object[] {a, b, c});
                });
            arguments = new object[] {testVal,testVal2,testVal3};
            _clickEventThreeArgs = eventClick;
        }
        
        public void AddListener <T,T2,T3,T4>(GameObject controller ,string methodName, T testVal, T2 testVal2, T3 testVal3, T4 testVal4)
        {
            Type controllerType = Type.GetType(controller.name);
            MethodInfo controllerMethod = controllerType.GetMethod(methodName);
            ClickEvent<T,T2,T3,T4> eventClick = new ClickEvent<T, T2, T3, T4>();
            eventClick.AddListener(
                (T a, T2 b, T3 c, T4 d) => { controllerMethod.Invoke(controller.GetComponent(controllerType), new object[] {a, b,c,d});
            });
            arguments = new object[] {testVal,testVal2,testVal3,testVal4};
            _clickEventFourArgs = eventClick;
        }

        public void Invoke()
        {
            switch (arguments.Length)
            {
                case 0:
                    _clickEvent.Invoke();
                    break;
                case 1:
                    _clickEventOneArg.Invoke(arguments[0]);
                    break;
                case 2:
                    _clickEventTwoArgs.Invoke(arguments[0],arguments[1]);
                    break;
                case 3:
                    _clickEventThreeArgs.Invoke(arguments[0],arguments[1],arguments[2]);
                    break;
                case 4:
                    _clickEventFourArgs.Invoke(arguments[0],arguments[1],arguments[2],arguments[3]);
                    break;
                
            }
        }
    }
}