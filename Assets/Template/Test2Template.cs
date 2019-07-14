using Munderwood.UI.Canvas;
using UnityEngine;

namespace Project.Test
{
    public class Test2Template : ITemplate
    {
        public void Build(CanvasBuilderFactory canvasBuilderFactory)
        {
            CanvasBuilder canvasBuilder1 = canvasBuilderFactory.Create("Test canvas 3",2,100,-100);
            canvasBuilder1.Button.Text("Test Button 5").Position(0,-20).Size(100,20).Click("Project.Test.TestController","Hello");
            canvasBuilder1.Button.Text("Test Button 6").Position(0,-40).Size(100,20);
        }
    }
}