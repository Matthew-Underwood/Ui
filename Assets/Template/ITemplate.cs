using Munderwood.UI.Canvas;
using UnityEngine.EventSystems;

namespace Project.Test
{
    public interface ITemplate
    {
        void Build(CanvasBuilderFactory canvasBuilderFactory);
    }
    
}