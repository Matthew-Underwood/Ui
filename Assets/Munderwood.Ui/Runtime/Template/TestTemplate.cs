using Munderwood.Ui.Canvas.Builder;
using Munderwood.Ui.Canvas.Factories;
using Project.Test;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Munderwood.Ui.Template
{
    public class TestTemplate : ITemplate
    {
        public void Build(CanvasBuilderFactory canvasBuilderFactory, PointerEventData pointerEventData, object[] values)
        {
            CanvasBuilder canvasBuilder = canvasBuilderFactory.Create("test",1,new Vector2(0,0));
            canvasBuilder.Button.Text("Test").Event.Click("Project.Test.TestController","Hello");
        }
    }
}