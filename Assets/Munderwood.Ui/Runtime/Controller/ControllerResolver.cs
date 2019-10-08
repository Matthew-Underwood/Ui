using System.Collections.Generic;
using UnityEngine;

namespace Munderwood.Ui.Controller
{
    public class ControllerResolver
    {
        private readonly ControllerFactory _controllerFactory;
        private readonly Dictionary<string,GameObject> _controllerRegistry;
        public ControllerResolver(Dictionary<string,GameObject> controllerRegistry,ControllerFactory controllerFactory)
        {
            _controllerRegistry = controllerRegistry;
            _controllerFactory = controllerFactory;
        }

        public GameObject Resolve(string controllerName)
        {
            if (!_controllerRegistry.ContainsKey(controllerName))
            {
                _controllerRegistry.Add(controllerName,_controllerFactory.CreateController(controllerName));
            }

            return _controllerRegistry[controllerName];
        }
    }
}