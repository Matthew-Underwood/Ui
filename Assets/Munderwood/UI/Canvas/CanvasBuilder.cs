using Munderwood.UI.Controller;
using UnityEngine;

namespace Munderwood.UI.Canvas
{
    public class CanvasBuilder
    {
        protected GameObject canvas;
        protected ControllerResolver controllerResolver;
        public CanvasButtonsBuilder Button {
            get
            {
                return new CanvasButtonsBuilder(canvas,controllerResolver);
            }
        } 

        public CanvasBuilder(GameObject canvas, ControllerResolver controllerResolver)
        {
            this.canvas = canvas;
            this.controllerResolver = controllerResolver;
        }

    }
}