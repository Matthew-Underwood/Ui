using Munderwood.UI.Canvas;
using Munderwood.UI.Invoker;
using Munderwood.UI.Template;
using UnityEngine;

namespace Munderwood.UI.Controller
{
    public class ControllerFactory
    {
        private readonly ControllerRegistry _controllerRegistry;
        private readonly TemplateFactory _templateFactory;
        private readonly InvokerRegistry _invokerRegistry;

        public ControllerFactory(ControllerRegistry controllerRegistry,TemplateFactory templateFactory,InvokerRegistry invokerRegistry)
        {
            _controllerRegistry = controllerRegistry;
            _templateFactory = templateFactory;
            _invokerRegistry = invokerRegistry;
        }
        
        public GameObject CreateController(string name)
        {
           GameObject controllerGameObject = new GameObject();
           controllerGameObject.name = name;
           controllerGameObject.AddComponent(System.Type.GetType(name));
           BaseController baseController = controllerGameObject.GetComponent<BaseController>();
           baseController.TemplateFactory = _templateFactory;
           baseController.InvokerRegistry = _invokerRegistry;
           baseController.CanvasBuilderFactory = new CanvasBuilderFactory(_controllerRegistry,_templateFactory,_invokerRegistry);
           return controllerGameObject;
        }
    }
}