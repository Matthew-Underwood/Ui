using System.Collections.Generic;
using UnityEngine;

namespace Munderwood.UI.Invoker
{
    public class InvokerRegistry
    {
        protected Dictionary<string, ITypeInvoker> invokers = new Dictionary<string, ITypeInvoker>();


        public void Add (string name, ITypeInvoker controller)
        {
            invokers.Add(name,controller);
        }
        
        public bool Contains (string name)
        {
            return invokers.ContainsKey(name);
        }
        
        public ITypeInvoker Get (string name)
        {
            return invokers[name];
        }
    }
}