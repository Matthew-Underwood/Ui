using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;

namespace Munderwood.UI.Canvas
{
    public class CanvasFactory
    {
        public GameObject Create(string name,int level, int x , int y)
        {
            GameObject masterCanvas;
            GameObject canvas;
            if (!this.CanvasExists("masterCanvas"))
            {
                masterCanvas = this.CreateCanvas("masterCanvas",0,0,0);
            }
            else
            {
                masterCanvas = GameObject.Find("masterCanvas");    
            }
            
            if (!this.CanvasExists(name))
            {
                 canvas = this.CreateCanvas(name, level,x,y,masterCanvas);
            } else
            {
                canvas = GameObject.Find(name);    
            }

            return canvas;
        }

        protected GameObject CreateCanvas(string name,int level , int x,int y, GameObject parentCanvas = null)
        {
            GameObject createdCanvas = Object.Instantiate(Resources.Load<GameObject>("Canvas"));
            createdCanvas.name = name;
            createdCanvas.tag = "Canvas";
            RectTransform rectTransform = createdCanvas.GetComponent<RectTransform>();
            createdCanvas.GetComponent<CanvasMeta>().Level = level;
            rectTransform.anchoredPosition = new Vector2(x, y);
            rectTransform.pivot = new Vector2(0, 0);

            if (parentCanvas != null)
            {
                createdCanvas.transform.parent = parentCanvas.transform;
            }
            return createdCanvas;
        }

        protected bool CanvasExists(string name)
        {
            return GameObject.Find(name) != null;
        }
    }
}