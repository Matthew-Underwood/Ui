using System;
using Munderwood.Ui.Canvas.Factories;
using Munderwood.Ui.Invoker;
using Munderwood.Ui.Template;
using UnityEngine;

namespace Munderwood.Ui.Controller
{
    public class ControllerFactory
    {
        private readonly RegistryManager _registryManager;
        private BasicTypeInvoker _basicTypeInvoker;

        public ControllerFactory(RegistryManager registryManager,BasicTypeInvoker basicTypeInvoker)
        {
            _registryManager = registryManager;
            _basicTypeInvoker = basicTypeInvoker;
        }
        
        public GameObject CreateController(Type controller)
        {
           GameObject controllerGameObject = new GameObject();
           controllerGameObject.name = controller.ToString();
           controllerGameObject.AddComponent(controller);
           BaseController baseController = controllerGameObject.GetComponent<BaseController>();
           baseController.TemplateFactory = new TemplateFactory(_registryManager.TemplateRegistry);
           baseController.BasicTypeInvoker = _basicTypeInvoker;
           baseController.CanvasBuilderFactory = new CanvasBuilderFactory(_registryManager,_basicTypeInvoker);
           return controllerGameObject;
        }
    }
}