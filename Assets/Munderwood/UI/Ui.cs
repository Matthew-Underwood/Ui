
using Munderwood.UI.Controller;
using Munderwood.UI.Invoker;
using Munderwood.UI.Template;
using UnityEngine;

namespace Munderwood.UI
{
    public class Ui
    {
        public static ControllerRegistry ControllerRegistry => controllerRegistry;

        protected static ControllerFactory controllerFactory;
        protected static ControllerRegistry controllerRegistry;
        protected static TemplateFactory templateFactory;
        protected static InvokerRegistry invokerRegistry;
        
        public Ui (ControllerRegistry controllerRegistry,ControllerFactory controllerFactory,TemplateFactory templateFactory, InvokerRegistry invokerRegistry)
        {
            Ui.controllerRegistry = controllerRegistry;
            Ui.controllerFactory = controllerFactory;
            Ui.templateFactory = templateFactory;
            Ui.invokerRegistry = invokerRegistry;
        }
        
        //TODO rename method to AddController
        //TODO add parameters argument to pass through to Call method
        public static void AddController(string name, string methodName)
        {
            var controller = controllerFactory.CreateController(name);
            controllerRegistry.Add(name,controller);
            invokerRegistry.Get("GameObjectInvoker").CallMethod(controller,methodName);
        }

        public static ControllerRegistry GetControllerRegistry()
        {
            return Ui.controllerRegistry;
        }

        
        //TODO rename to CallTemplate
        public static void Template (string name)
        {
            var template = Ui.templateFactory.CreateTemplate(name);
            invokerRegistry.Get("BasicInvoker").CallMethod(template, "Build");
        }
        
        
    }
}
