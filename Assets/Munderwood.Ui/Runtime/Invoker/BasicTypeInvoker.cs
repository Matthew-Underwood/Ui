using System;
using System.Reflection;
using UnityEngine;

namespace Munderwood.UI.Invoker
{
    public class BasicTypeInvoker : ITypeInvoker
    {
        public void CallMethod(object resolvedType, string name, object[] parameters)
        {
            MethodInfo theMethod = resolvedType.GetType().GetMethod(name);
            theMethod.Invoke(resolvedType, parameters);
        }
    }
}