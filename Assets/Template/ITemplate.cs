using Munderwood.UI.Canvas;
using UnityEngine.EventSystems;

namespace Project.Test
{
    public interface ITemplate
    {
        void Build(CanvasBuilderFactory canvasBuilderFactory);
    }
    
    public interface ITemplateEventData
    {
        void Build(CanvasBuilderFactory canvasBuilderFactory,PointerEventData eventData);
    }
}