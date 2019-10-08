using System;
using System.Reflection;
using Munderwood.Ui.Invoker;
using UnityEngine;

namespace Munderwood.Ui
{
    public class GameObjectInvoker : ITypeInvoker
    {
        public void CallMethod(object resolvedObject, string name, object[] parameters)
        {
            GameObject resolvedGameObject = resolvedObject as GameObject;
            Component script = resolvedGameObject.GetComponent(Type.GetType(resolvedGameObject.name));
            MethodInfo theMethod = script.GetType().GetMethod(name);
            //TODO implement invoke to pass parameters
            theMethod.Invoke(script, parameters);
        }
    }
}