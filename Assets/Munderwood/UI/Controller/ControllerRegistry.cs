using System.Collections.Generic;
using UnityEngine;

namespace Munderwood.UI.Controller
{
    public class ControllerRegistry
    {
        protected Dictionary<string, GameObject> controllers = new Dictionary<string, GameObject>();


        public void Add (string name, GameObject controller)
        {
            controllers.Add(name,controller);
        }
        
        public bool Contains (string name)
        {
            return controllers.ContainsKey(name);
        }
        
        public GameObject Get (string name)
        {
            return controllers[name];
        }
    }
}