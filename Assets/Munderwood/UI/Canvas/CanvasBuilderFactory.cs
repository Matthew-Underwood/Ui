using Munderwood.UI.Controller;
using Munderwood.UI.Invoker;
using Munderwood.UI.Template;
using UnityEngine;

namespace Munderwood.UI.Canvas
{
    public class CanvasBuilderFactory
    {
        private readonly RegistryManager _registryManager;
        private readonly ControllerRegistry _controllerRegistry;
        private readonly TemplateRegistry _templateRegistry;
        private readonly TemplateFactory _templateFactory;
        private readonly InvokerRegistry _invokerRegistry;
        private readonly ControllerFactory _controllerFactory;

        public CanvasBuilderFactory(RegistryManager registryManager)
        {
            _registryManager = registryManager;
        }
        
        public CanvasBuilder Create(string name,int level, int x,int y)
        {
            ControllerFactory controllerFactory = new ControllerFactory(_registryManager);
            ControllerResolver controllerResolver = new ControllerResolver(_registryManager.ControllerRegistry,controllerFactory);
            GameObject canvas = (new CanvasFactory()).Create(name,level,x,y);
            CanvasBuilder canvasBuilder = new CanvasBuilder(canvas,controllerResolver);
            return canvasBuilder;
        }
    }
}