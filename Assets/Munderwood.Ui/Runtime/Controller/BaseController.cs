using System;
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
        protected BasicTypeInvoker basicTypeInvoker;
        protected CanvasBuilderFactory canvasBuilderFactory;
        protected PointerEventData pointerEventData;

        public TemplateFactory TemplateFactory
        {
            get => templateFactory;
            set => templateFactory = value;
        }
        
        public BasicTypeInvoker BasicTypeInvoker
        {
            get => basicTypeInvoker;
            set => basicTypeInvoker = value;
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

        protected void Template (Type type, object values = null)
        {
            ITemplate template = TemplateFactory.CreateTemplate(type);
            BasicTypeInvoker.CallMethod(template, "Build",new object[]{CanvasBuilderFactory,this.pointerEventData,values});
        }
    }
}