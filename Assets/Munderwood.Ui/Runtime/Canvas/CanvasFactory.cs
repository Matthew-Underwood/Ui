using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;

namespace Munderwood.Ui.Canvas
{
    public class CanvasFactory
    {
        public GameObject Create(string name,int level, Vector2 position)
        {
            GameObject masterCanvas;
            GameObject canvas;
            if (!this.CanvasExists("masterCanvas"))
            {
                masterCanvas = this.CreateCanvas("masterCanvas",0,new Vector2(0,0));
            }
            else
            {
                masterCanvas = GameObject.Find("masterCanvas");    
            }
            
            if (!this.CanvasExists(name))
            {
                 canvas = this.CreateCanvas(name, level,position,masterCanvas);
            } else
            {
                canvas = GameObject.Find(name);    
            }

            return canvas;
        }
        protected GameObject CreateCanvas(string name,int level , Vector2 position, GameObject parentCanvas = null)
        {
            GameObject createdCanvas = Object.Instantiate(Resources.Load<GameObject>("Canvas"));
            createdCanvas.name = name;
            createdCanvas.tag = "Canvas";
            RectTransform rectTransform = createdCanvas.GetComponent<RectTransform>();
            rectTransform.anchorMin = new Vector2(0,1);
            rectTransform.anchorMax = new Vector2(0,1);
            createdCanvas.GetComponent<CanvasMeta>().Level = level;
            rectTransform.anchoredPosition = CoordinateTransform.InverseYCoordinate(position);
            rectTransform.pivot = new Vector2(0, 1);

            if (parentCanvas != null)
            {
                createdCanvas.transform.SetParent(parentCanvas.transform,false);
            }
            return createdCanvas;
        }

        protected bool CanvasExists(string name)
        {
            return GameObject.Find(name) != null;
        }
    }
}