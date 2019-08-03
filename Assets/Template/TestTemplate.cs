using Munderwood.UI.Canvas;
using UnityEngine;

namespace Project.Test
{
    public class TestTemplate : ITemplate
    {
        public void Build(CanvasBuilderFactory canvasBuilderFactory)
        {
            CanvasBuilder canvasBuilder1 = canvasBuilderFactory.Create("Test canvas 1",1,0,0);
            canvasBuilder1.Button.Text("Remove canvas").Position(0,-40).Size(100,20).Event.Click("Project.Test.RemoveCanvasController","RemoveCanvases",2);
            
            CanvasBuilder canvasBuilder2 = canvasBuilderFactory.Create("Test canvas 2",2,600,0);
            canvasBuilder2.Button.Text("Test Button 3").Position(0,-20).Size(100,20);
            canvasBuilder2.Button.Text("No args").Position(0,-40).Size(100,20).Event.Click("Project.Test.TestBController","NoArgsMethod");
            canvasBuilder2.Button.Text("1 args").Position(0,-60).Size(100,20).Event.Click("Project.Test.TestBController","OneArgMethod","Sam" );
            canvasBuilder2.Button.Text("2 args").Position(0,-80).Size(100,20).Event.Click("Project.Test.TestBController","TwoArgsMethod","Gary" , 9.9);
            canvasBuilder2.Button.Text("3 args").Position(0,-100).Size(100,20).Event.Click("Project.Test.TestBController","ThreeArgsMethod","Jim" , 9.9, 2);
            canvasBuilder2.Button.Text("4 args").Position(0,-120).Size(100,20).Event.Click("Project.Test.TestBController","FourArgsMethod", 9.9,"John" ,9,"Smith");
            canvasBuilder2.Button.Text("Open canvas").Position(0,-140).Size(100,20).Event.Hover("Project.Test.TestBController","UnitPanel");
        }
    }
}