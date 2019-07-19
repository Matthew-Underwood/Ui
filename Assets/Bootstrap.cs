using Munderwood.Test;
using Munderwood.UI;
using Munderwood.UI.Boostrapper;
using Munderwood.UI.Controller;

public class Bootstrap : IBootstrap 
{
    public Bootstrap()
    {
        RegistryManager registryManager = (new RegistryManagerFactory()).Create();
        ControllerFactory controllerFactory = new ControllerFactory(registryManager);
        Setup(new Bootstrapper(registryManager,controllerFactory));
    }

    public void Setup (Bootstrapper bootstrapper)
    {
        bootstrapper.AddController("Project.Test.TestController", "UnitPanel",null);
    }
    
}
