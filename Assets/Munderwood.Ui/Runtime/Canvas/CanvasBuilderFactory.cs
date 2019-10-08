using Munderwood.Ui.Controller;
using Munderwood.Ui.Template;
using Munderwood.Ui.Invoker;
using UnityEngine;

namespace Munderwood.Ui.Canvas
{
    public class CanvasBuilderFactory
    {
        private readonly RegistryManager _registryManager;
        private readonly TemplateFactory _templateFactory;
        private readonly ControllerFactory _controllerFactory;

        public CanvasBuilderFactory(RegistryManager registryManager)
        {
            _registryManager = registryManager;
        }
        
        public CanvasBuilder Create(string name,int level, Vector2 position)
        {
            ControllerFactory controllerFactory = new ControllerFactory(_registryManager);
            ControllerResolver controllerResolver = new ControllerResolver(_registryManager.ControllerRegistry,controllerFactory);
            GameObject canvas = (new CanvasFactory()).Create(name,level,position);
            CanvasDimensionsTransformer canvasDimensionsTransformer = new CanvasDimensionsTransformer(canvas);
            CanvasBuilder canvasBuilder = new CanvasBuilder(canvas,controllerResolver,canvasDimensionsTransformer);
            return canvasBuilder;
        }
    }
}