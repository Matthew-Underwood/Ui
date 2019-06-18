using System.Collections.Generic;
using UnityEngine;

namespace Munderwood.UI.Controller
{
    public class ControllerResolver
    {
        private readonly ControllerFactory _controllerFactory;
        private readonly ControllerRegistry _controllerRegistry;
        public ControllerResolver(ControllerRegistry controllerRegistry ,ControllerFactory controllerFactory)
        {
            _controllerRegistry = controllerRegistry;
            _controllerFactory = controllerFactory;
        }

        public GameObject Resolve(string controllerName)
        {
            if (!_controllerRegistry.Contains(controllerName))
            {
                _controllerRegistry.Add(controllerName,_controllerFactory.CreateController(controllerName));
            }

            return _controllerRegistry.Get(controllerName);
        }
    }
}