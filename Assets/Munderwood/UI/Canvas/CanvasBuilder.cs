using Munderwood.UI.Controller;
using UnityEngine;

namespace Munderwood.UI.Canvas
{
    public class CanvasBuilder
    {
        protected GameObject canvas;
        private readonly ControllerResolver _controllerResolver;
        public CanvasButtonsBuilder Button {
            get
            {
                return new CanvasButtonsBuilder(canvas,_controllerResolver);
            }
        } 

        public CanvasBuilder(GameObject canvas, ControllerResolver controllerResolver)
        {
            this.canvas = canvas;
            _controllerResolver = controllerResolver;
        }

    }
}