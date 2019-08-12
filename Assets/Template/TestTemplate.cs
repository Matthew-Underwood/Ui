using JetBrains.Annotations;
using Munderwood.UI.Canvas;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Project.Test
{
    public class TestTemplate : ITemplate
    {
        public void Build(CanvasBuilderFactory canvasBuilderFactory, PointerEventData pointerEventData, object[] values)
        {
            CanvasBuilder canvasBuilder1 = canvasBuilderFactory.Create("Test canvas 1",1,0,0);
            canvasBuilder1.Button.Text("Remove canvas").Position(0,-40).Size(100,20).Event.Click("Project.Test.RemoveCanvasController","RemoveCanvases",2);
            
            CanvasBuilder canvasBuilder2 = canvasBuilderFactory.Create("Test canvas 2",2,600,0);
            canvasBuilder2.Button.Text("Test Button 3").Position(0,-20).Size(100,20);
            canvasBuilder2.Button.Text("No args").Position(0,-40).Size(100,20).Event.Click("Project.Test.TestBController","NoArgsMethod");
            canvasBuilder2.Button.Text("1 args").Position(0,-60).Size(100,20).Event.Click("Project.Test.TestBController","OneArgMethod",values[0]  + " " + values[1]);
            canvasBuilder2.Button.Text("2 args").Position(0,-80).Size(100,20).Event.Click("Project.Test.TestBController","TwoArgsMethod","Gary" , 9.9);
            canvasBuilder2.Button.Text("3 args").Position(0,-100).Size(100,20).Event.Click("Project.Test.TestBController","ThreeArgsMethod","Jim" , 9.9, 2);
            canvasBuilder2.Button.Text("4 args").Position(0,-120).Size(100,20).Event.Click("Project.Test.TestBController","FourArgsMethod", 9.9,"John" ,9,"Smith");
            canvasBuilder2.Button.Text("Open canvas").Position(0,-140).Size(100,20).Event.HoverIn("Project.Test.TestBController","UnitPanel");
            canvasBuilder2.Button.Text("Hover test").Position(0,-160).Size(100,20).Event.HoverIn("Project.Test.TestBController","In","matt",2).HoverOut("Project.Test.TestBController","Out","dave",5);
        }
    }
}