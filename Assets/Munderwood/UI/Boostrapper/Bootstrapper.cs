using Munderwood.UI.Action;
using Munderwood.UI.Controller;

namespace Munderwood.UI.Boostrapper
{
    public class Bootstrapper
    {
        private readonly RegistryManager _registryManager;
        private readonly ControllerFactory _controllerFactory;

        public Bootstrapper(
            RegistryManager registryManager,
            ControllerFactory controllerFactory
            )
        {
            _registryManager = registryManager;
            _controllerFactory = controllerFactory;
        }

        public void AddController (string name, string methodName, object[] parameters)
        {
            var controller = _controllerFactory.CreateController(name);
            _registryManager.ControllerRegistry.Add(name,controller);
            _registryManager.InvokerRegistry["GameObjectInvoker"].CallMethod(controller,methodName,parameters);
        }
    }
}