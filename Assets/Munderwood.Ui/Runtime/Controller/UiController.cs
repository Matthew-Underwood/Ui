namespace Munderwood.Ui.Controller
{
    public class UiController
    {
        private readonly RegistryManager _registryManager;
        private readonly ControllerFactory _controllerFactory;

        public UiController (RegistryManager registryManager,ControllerFactory controllerFactory)
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