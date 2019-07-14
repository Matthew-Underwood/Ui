using Munderwood.Test;
using Munderwood.UI;
using Munderwood.UI.Boostrapper;
using Munderwood.UI.Controller;
using Munderwood.UI.Invoker;
using Munderwood.UI.Template;

public class Bootstrap : IBootstrap 
{
    public Bootstrap()
    {
        ControllerRegistry controllerRegistry = new ControllerRegistry();
        TemplateRegistry templateRegistry = new TemplateRegistry();
        InvokerRegistry invokerRegistry = new InvokerRegistry();
        invokerRegistry.Add("BasicInvoker", new BasicTypeInvoker());
        invokerRegistry.Add("GameObjectInvoker", new GameObjectInvoker());
        ControllerFactory controllerFactory = new ControllerFactory(controllerRegistry,templateRegistry,invokerRegistry);

        Setup(new Bootstrapper(controllerRegistry,controllerFactory,invokerRegistry));
    }

    public void Setup (Bootstrapper bootstrapper)
    {
        bootstrapper.AddController("Project.Test.TestController", "UnitPanel",null);
    }
    
}
