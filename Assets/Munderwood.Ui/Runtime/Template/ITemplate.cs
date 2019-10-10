using JetBrains.Annotations;
using Munderwood.Ui.Canvas.Factories;
using UnityEngine.EventSystems;

namespace Project.Test
{
    public interface ITemplate
    {
        void Build(CanvasBuilderFactory canvasBuilderFactory,[CanBeNull] PointerEventData pointerEventData, [CanBeNull] object[] values);
    }
    
}