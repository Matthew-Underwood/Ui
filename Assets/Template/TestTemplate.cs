using Munderwood.UI.Canvas;
using UnityEngine;

namespace Project.Test
{
    public class TestTemplate : ITemplate
    {
        public void Build()
        {
            CanvasBuilder canvasBuilder1 = (new CanvasBuilderFactory()).Create("Test canvas 1",1,0,0);
            canvasBuilder1.Button.Text("Test Button 1").Position(0,-20).Size(100,20);
            canvasBuilder1.Button.Text("Test Button 2").Position(0,-40).Size(100,20);
            
            CanvasBuilder canvasBuilder2 = (new CanvasBuilderFactory()).Create("Test canvas 2",1,600,0);
            canvasBuilder2.Button.Text("Test Button 3").Position(0,-20).Size(100,20);
            canvasBuilder2.Button.Text("Test Button 4").Position(0,-40).Size(100,20).Click("Project.Test.TestBController","UnitPanel",null);
            canvasBuilder2.Button.Text("Test Button 5").Position(0, -60).Size(100, 20).RemoveCanvases(2);
            canvasBuilder2.Button.Text("Test Button 6").Position(0,-80).Size(100,20).Click("Project.Test.TestBController","TestHello",new object[] {"Matthew", "Graham","Underwood"});
        }
    }
}