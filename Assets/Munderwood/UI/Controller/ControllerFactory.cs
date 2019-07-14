using Munderwood.UI.Canvas;
using Munderwood.UI.Invoker;
using Munderwood.UI.Template;
using UnityEngine;

namespace Munderwood.UI.Controller
{
    public class ControllerFactory
    {
        private readonly ControllerRegistry _controllerRegistry;
        private readonly TemplateRegistry _templateRegistry;
        private readonly InvokerRegistry _invokerRegistry;

        public ControllerFactory(ControllerRegistry controllerRegistry,TemplateRegistry templateRegistry,InvokerRegistry invokerRegistry)
        {
            _controllerRegistry = controllerRegistry;
            _templateRegistry = templateRegistry;
            _invokerRegistry = invokerRegistry;
        }
        
        public GameObject CreateController(string name)
        {
           GameObject controllerGameObject = new GameObject();
           controllerGameObject.name = name;
           controllerGameObject.AddComponent(System.Type.GetType(name));
           BaseController baseController = controllerGameObject.GetComponent<BaseController>();
           baseController.TemplateFactory = new TemplateFactory(_templateRegistry);
           baseController.InvokerRegistry = _invokerRegistry;
           baseController.CanvasBuilderFactory = new CanvasBuilderFactory(_controllerRegistry,_templateRegistry,_invokerRegistry);
           return controllerGameObject;
        }
    }
}