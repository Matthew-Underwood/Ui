
using System;
using System.Reflection;
using Munderwood.UI.Event.Click;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Munderwood.UI.Event
{
    public class PointerDataEventManager
    {
        private readonly GameObject _gameObject;
        private readonly Type _gameObjectType;
        private readonly MethodInfo method;
        private IEventOneArg pointerEvent;
        private object[] arguments;
        

        public PointerDataEventManager (GameObject gameObject, string methodName)
        {
            _gameObject = gameObject;
            _gameObjectType = Type.GetType(gameObject.name);
            method = _gameObjectType.GetMethod(methodName);
        }
        
        public void AddListener (PointerEventData pointerEventData)
        {
            ClickEvent<PointerEventData> eventClick = new ClickEvent<PointerEventData>();
            eventClick.AddListener(
                (PointerEventData a) => { method.Invoke(_gameObject.GetComponent(_gameObjectType), new object[] {a});
                });
            pointerEvent = eventClick;
        }
        
        public void AssignValues (PointerEventData pointerEventData)
        {
            arguments = new object[] {pointerEventData};
        }
        
        public void Invoke()
        {
            pointerEvent.Invoke(arguments[0]);
        }
        
    }
}