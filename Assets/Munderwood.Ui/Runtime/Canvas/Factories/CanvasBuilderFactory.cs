using Munderwood.Core.Invoker;
using Munderwood.Ui.Canvas.Builder;
using Munderwood.Ui.Controller;
using Munderwood.Ui.Template;
using UnityEngine;

namespace Munderwood.Ui.Canvas.Factories
{
    public class CanvasBuilderFactory
    {
        private readonly RegistryManager _registryManager;
        private readonly BasicTypeInvoker _basicTypeInvoker;
        private readonly TemplateFactory _templateFactory;
        private readonly ControllerFactory _controllerFactory;

        public CanvasBuilderFactory(RegistryManager registryManager,BasicTypeInvoker basicTypeInvoker)
        {
            _registryManager = registryManager;
            _basicTypeInvoker = basicTypeInvoker;
        }
        
        public CanvasBuilder Create(string name,int level, Vector2 position)
        {
            ControllerFactory controllerFactory = new ControllerFactory(_registryManager,_basicTypeInvoker);
            ControllerResolver controllerResolver = new ControllerResolver(_registryManager.ControllerRegistry,controllerFactory);
            GameObject canvas = (new CanvasFactory()).Create(name,level,position);
            CanvasDimensionsTransformer canvasDimensionsTransformer = new CanvasDimensionsTransformer(canvas);
            CanvasBuilder canvasBuilder = new CanvasBuilder(canvas,controllerResolver,canvasDimensionsTransformer);
            return canvasBuilder;
        }
    }
}