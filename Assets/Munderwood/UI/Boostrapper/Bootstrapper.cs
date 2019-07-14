using Munderwood.UI.Controller;
using Munderwood.UI.Invoker;
using Munderwood.UI.Template;

namespace Munderwood.UI.Boostrapper
{
    public class Bootstrapper
    {
        private readonly ControllerRegistry _controllerRegistry;
        private readonly ControllerFactory _controllerFactory;
        private readonly InvokerRegistry _invokerRegistry;

        public Bootstrapper(
            ControllerRegistry controllerRegistry,
            ControllerFactory controllerFactory,
            InvokerRegistry invokerRegistry
            )
        {
            _controllerRegistry = controllerRegistry;
            _controllerFactory = controllerFactory;
            _invokerRegistry = invokerRegistry;
        }

        public void AddController (string name, string methodName, object[] parameters)
        {
            var controller = _controllerFactory.CreateController(name);
            _controllerRegistry.Add(name,controller);
            _invokerRegistry.Get("GameObjectInvoker").CallMethod(controller,methodName,parameters);
        }
    }
}