using UnityEngine;

namespace Munderwood.UI.Canvas
{
    public class CanvasBuilder
    {
        protected GameObject canvas;
        public CanvasButtonsBuilder Button {
            get
            {
                return new CanvasButtonsBuilder(canvas);
            }
        } 

        public CanvasBuilder(GameObject canvas)
        {
            this.canvas = canvas;
        }

    }
}