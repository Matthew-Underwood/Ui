using Munderwood.UI.Controller;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace Munderwood.UI.Canvas
{
    public class CanvasButtonsBuilder : CanvasBuilder
    {
        private readonly GameObject button;

        public CanvasButtonsBuilder(GameObject canvas,ControllerResolver controllerResolver,CanvasDimensionsTransformer canvasDimensionsTransformer) : base(canvas,controllerResolver,canvasDimensionsTransformer)
        {
            this.canvas = canvas;
            this.controllerResolver = controllerResolver;
            this.canvasDimensionsTransformer = canvasDimensionsTransformer;
            this.button = Object.Instantiate(Resources.Load<GameObject>("Button"));
            this.button.transform.SetParent(this.canvas.transform,false);
        }
        
        public ButtonEventBuilder Event {
            get
            {
                return new ButtonEventBuilder(this.canvas,this.controllerResolver,canvasDimensionsTransformer,this.button);
            }
        } 
        
        public CanvasButtonsBuilder Text (string text)
        {
            Text textComponent = this.button.transform.Find("Text").GetComponent<Text>();
            textComponent.text = text;
            return this;
        }
        
        public CanvasButtonsBuilder Position (int x, int y)
        {
            this.button.GetComponent<RectTransform>().anchoredPosition = new Vector3(x,y,0.0f);
            return this;
        }
        
        public CanvasButtonsBuilder Size (int width, int height)
        {
            this.button.GetComponent<RectTransform>().sizeDelta = new Vector2(width,height);
            return this;
        }
    }
}