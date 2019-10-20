using System;
using Munderwood.Ui.Invoker;
using UnityEngine;

namespace Munderwood.Ui.Controller
{
    public class BootStrap
    {
        private readonly RegistryManager _registryManager;
        private readonly ControllerFactory _controllerFactory;
        private readonly BasicTypeInvoker _basicTypeInvoker;

        public BootStrap (
            RegistryManager registryManager,
            ControllerFactory controllerFactory,
            BasicTypeInvoker basicTypeInvoker
        )
        {
            _registryManager = registryManager;
            _basicTypeInvoker = basicTypeInvoker;
            _controllerFactory = controllerFactory;
        }

        public void AddController (Type controller, string methodName, object[] parameters)
        {
            GameObject createdController = _controllerFactory.CreateController(controller);
            _registryManager.ControllerRegistry.Add(createdController.name,createdController);
            _basicTypeInvoker.CallMethod(createdController.GetComponent(controller),methodName,parameters);
        }
    }
}