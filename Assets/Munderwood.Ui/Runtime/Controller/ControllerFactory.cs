using Munderwood.Ui.Canvas.Factories;
using Munderwood.Ui.Template;
using UnityEngine;

namespace Munderwood.Ui.Controller
{
    public class ControllerFactory
    {
        private readonly RegistryManager _registryManager;

        public ControllerFactory(RegistryManager registryManager)
        {
            _registryManager = registryManager;
        }
        
        public GameObject CreateController(string name)
        {
           GameObject controllerGameObject = new GameObject();
           controllerGameObject.name = name;
           controllerGameObject.AddComponent(System.Type.GetType(name));
           BaseController baseController = controllerGameObject.GetComponent<BaseController>();
           baseController.TemplateFactory = new TemplateFactory(_registryManager.TemplateRegistry);
           baseController.InvokerRegistry = _registryManager.InvokerRegistry;
           baseController.CanvasBuilderFactory = new CanvasBuilderFactory(_registryManager);
           return controllerGameObject;
        }
    }
}