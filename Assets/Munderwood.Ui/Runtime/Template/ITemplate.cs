using JetBrains.Annotations;
using Munderwood.Ui.Canvas.Factories;
using UnityEngine.EventSystems;

namespace Munderwood.Ui.Template
{
    public interface ITemplate
    {
        void Build(CanvasBuilderFactory canvasBuilderFactory,[CanBeNull] PointerEventData pointerEventData, [CanBeNull] object[] values);
    }
    
}