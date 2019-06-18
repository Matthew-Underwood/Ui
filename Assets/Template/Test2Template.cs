using Munderwood.UI.Canvas;
using UnityEngine;

namespace Project.Test
{
    public class Test2Template : ITemplate
    {
        public void Build()
        {
            CanvasBuilder canvasBuilder1 = (new CanvasBuilderFactory()).Create("Test canvas 3",2,100,-100);
            canvasBuilder1.Button.Text("Test Button 5").Position(0,-20).Size(100,20);
            canvasBuilder1.Button.Text("Test Button 6").Position(0,-40).Size(100,20);
            canvasBuilder1.Button.Text("Cancel").Position(0, -60).Size(100, 20).RemoveCanvases(2);
        }
    }
}