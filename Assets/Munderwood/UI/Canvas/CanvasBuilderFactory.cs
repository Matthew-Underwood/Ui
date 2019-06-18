using UnityEngine;

namespace Munderwood.UI.Canvas
{
    public class CanvasBuilderFactory
    {
        public CanvasBuilder Create(string name,int level, int x,int y)
        {
            GameObject canvas = (new CanvasFactory()).Create(name,level,x,y);
            CanvasBuilder canvasBuilder = new CanvasBuilder(canvas);
            return canvasBuilder;
        }
    }
}