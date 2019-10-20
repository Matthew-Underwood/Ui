using System;
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

        public GameObject Resolve(Type controller)
        {
            if (!_controllerRegistry.ContainsKey(controller.ToString()))
            {
                _controllerRegistry.Add(controller.ToString(),_controllerFactory.CreateController(controller));
            }

            return _controllerRegistry[controller.ToString()];
        }
    }
}