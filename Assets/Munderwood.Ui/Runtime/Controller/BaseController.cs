using System.Collections.Generic;
using Munderwood.Test.Input;
using Munderwood.Ui.Canvas.Factories;
using Munderwood.Ui.Invoker;
using Munderwood.Ui.Template;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Munderwood.Ui.Controller
{
    public class BaseController : MonoBehaviour, IPointerData
    {
        protected TemplateFactory templateFactory;
        protected Dictionary<string, ITypeInvoker> invokerRegistry;
        protected CanvasBuilderFactory canvasBuilderFactory;
        protected PointerEventData pointerEventData;

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
        
        public void SetPointerEventData(PointerEventData pointerEventData)
        {
            this.pointerEventData = pointerEventData;
        }

        protected void Template (string name,object values = null)
        {
            var template = TemplateFactory.CreateTemplate(name);
            InvokerRegistry["BasicInvoker"].CallMethod(template, "Build",new object[]{CanvasBuilderFactory,this.pointerEventData,values});
        }
    }
}