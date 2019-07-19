using System.Collections.Generic;
using Munderwood.UI.Canvas;
using Munderwood.UI.Invoker;
using Munderwood.UI.Template;
using UnityEngine;

namespace Munderwood.UI.Controller
{
    public class BaseController : MonoBehaviour
    {
        protected TemplateFactory templateFactory;
        protected Dictionary<string, ITypeInvoker> invokerRegistry;
        protected CanvasBuilderFactory canvasBuilderFactory;

        public TemplateFactory TemplateFactory
        {
            get => templateFactory;
            set => templateFactory = value;
        }
        
        public Dictionary<string, ITypeInvoker> InvokerRegistry
        {
            get => invokerRegistry;
            set => invokerRegistry = value;
        }
        
        public CanvasBuilderFactory CanvasBuilderFactory
        {
            get => canvasBuilderFactory;
            set => canvasBuilderFactory = value;
        }

        protected void Template (string name)
        {
            var template = TemplateFactory.CreateTemplate(name);
            InvokerRegistry["BasicInvoker"].CallMethod(template, "Build",new object[]{CanvasBuilderFactory});
        }
    }
}