using Munderwood.UI.Canvas;
using UnityEngine.EventSystems;

namespace Project.Test
{
    public class Test2Template : ITemplate
    {
        public void Build(CanvasBuilderFactory canvasBuilderFactory)
        {
            CanvasBuilder canvasBuilder1 = canvasBuilderFactory.CreateRelative("Test canvas 3",2,625,-431 );
            canvasBuilder1.Button.Text("Hello")
                .Position(0, -20)
                .Size(100, 20)
                .Event.Click("Project.Test.TestController", "Hello")
                      .Click("Project.Test.TestController", "HelloAgain")
                      .Hover("Project.Test.TestController", "HoverGreeting","Matthew", "Underwood");
            canvasBuilder1.Button.Text("Test Button 6").Position(0,-40).Size(100,20);
        }
    }
}