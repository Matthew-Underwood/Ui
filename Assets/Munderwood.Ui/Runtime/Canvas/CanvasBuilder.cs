using Munderwood.Ui.Controller;
using UnityEngine;

namespace Munderwood.Ui.Canvas
{
    public class CanvasBuilder
    {
        protected GameObject canvas;
        protected ControllerResolver controllerResolver;
        protected CanvasDimensionsTransformer canvasDimensionsTransformer;

        public CanvasButtonsBuilder Button {
            get
            {
                return new CanvasButtonsBuilder(canvas,controllerResolver,canvasDimensionsTransformer);
            }
        }
        
        public CanvasLayoutBuilder Layout {
            get
            {
                return new CanvasLayoutBuilder(canvas,controllerResolver,canvasDimensionsTransformer);
            }
        }
        
        public GameObject Canvas {
            get
            {
                return this.canvas;
            }
        }
        
        public void AddCanvas (GameObject canvas) {
            canvas.transform.SetParent(this.canvas.transform,false);
        }

        public CanvasBuilder(GameObject canvas, ControllerResolver controllerResolver,CanvasDimensionsTransformer canvasDimensionsTransformer)
        {
            this.canvas = canvas;
            this.controllerResolver = controllerResolver;
            this.canvasDimensionsTransformer = canvasDimensionsTransformer;
        }

    }
}