using Munderwood.UI;
using Munderwood.UI.Controller;
using Munderwood.UI.Invoker;
using Munderwood.UI.Template;

namespace Munderwood.Test
{
    public class UiService : IService
    {
        public void Build()
        {
            ControllerRegistry controllerRegistry = new ControllerRegistry();
            ControllerFactory controllerFactory = new ControllerFactory();
            TemplateFactory templateFactory = new TemplateFactory();
            InvokerRegistry invokerRegistry = new InvokerRegistry();
            invokerRegistry.Add("BasicInvoker", new BasicTypeInvoker());
            invokerRegistry.Add("GameObjectInvoker", new GameObjectInvoker());
            Ui ui = new Ui(controllerRegistry,controllerFactory, templateFactory, invokerRegistry);
        }
    }

    public interface IService
    {
        void Build();
    }
}