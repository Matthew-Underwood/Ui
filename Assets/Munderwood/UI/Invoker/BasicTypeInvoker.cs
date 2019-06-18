using System;
using System.Reflection;
using UnityEngine;

namespace Munderwood.UI.Invoker
{
    public class BasicTypeInvoker : ITypeInvoker
    {
        public void CallMethod(object resolvedObject , string name)
        {
            MethodInfo theMethod = resolvedObject.GetType().GetMethod(name);
            //TODO inplement passing of parameters
            theMethod.Invoke(resolvedObject, null);
        }

    }
}