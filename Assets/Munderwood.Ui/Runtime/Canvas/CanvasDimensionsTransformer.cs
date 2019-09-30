using UnityEngine;

namespace Munderwood.UI.Canvas
{
    public class CanvasDimensionsTransformer
    {
        private GameObject Canvas { get; set; }

        public CanvasDimensionsTransformer(GameObject canvas)
        {
            Canvas = canvas;
        }

        public void SetHeight(float height)
        {
            Rect rect = Canvas.GetComponent<RectTransform>().rect;
            //Canvas.GetComponent<RectTransform>().rect = new Rect(0,0,rect.width,height);
        }
        
        public void SetWidth(float width)
        {
            Rect rect = Canvas.GetComponent<RectTransform>().rect;
            rect.width = width;
        }
    }
}