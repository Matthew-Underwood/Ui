using Munderwood.Ui.Controller;
using UnityEngine;
using UnityEngine.UI;

namespace Munderwood.Ui.Canvas.Builder
{
    public class CanvasLayoutBuilder : CanvasBuilder
    {
        public CanvasLayoutBuilder(GameObject canvas, ControllerResolver controllerResolver,CanvasDimensionsTransformer canvasDimensionsTransformer) : base(canvas,controllerResolver,canvasDimensionsTransformer) 
        {
            this.canvas = canvas;
            this.controllerResolver = controllerResolver;
            this.canvasDimensionsTransformer = canvasDimensionsTransformer;
        }
        
        public CanvasLayoutBuilder Horizontal (float spacing,RectOffset padding,TextAnchor textAnchor)
        {
            HorizontalLayoutGroup gridLayoutGroup = canvas.AddComponent<HorizontalLayoutGroup>();
            gridLayoutGroup.spacing = spacing;
            gridLayoutGroup.padding = padding;
            gridLayoutGroup.childAlignment = textAnchor;
            gridLayoutGroup.childForceExpandHeight = false;
            gridLayoutGroup.childForceExpandWidth = false;
            gridLayoutGroup.childControlHeight = false;
            gridLayoutGroup.childControlWidth = false;
            UnityEngine.Canvas.ForceUpdateCanvases();
            return this;
        }
        
        public CanvasLayoutBuilder Vertical (float spacing,RectOffset padding,TextAnchor textAnchor)
        {
            VerticalLayoutGroup gridLayoutGroup = canvas.AddComponent<VerticalLayoutGroup>();
            gridLayoutGroup.spacing = spacing;
            gridLayoutGroup.padding = padding;
            gridLayoutGroup.childAlignment = textAnchor;
            gridLayoutGroup.childForceExpandHeight = false;
            gridLayoutGroup.childForceExpandWidth = false;
            gridLayoutGroup.childControlHeight = false;
            gridLayoutGroup.childControlWidth = false;
            UnityEngine.Canvas.ForceUpdateCanvases();
            return this;
        }

        public CanvasLayoutBuilder Rows (int number,Vector2 spacing,Vector2 cellSize,TextAnchor textAnchor)
        {
            GridLayoutGroup gridLayoutGroup = canvas.AddComponent<GridLayoutGroup>();
            gridLayoutGroup.constraint = GridLayoutGroup.Constraint.FixedRowCount;
            gridLayoutGroup.constraintCount = number;
            gridLayoutGroup.spacing = spacing;
            gridLayoutGroup.cellSize = cellSize;
            gridLayoutGroup.childAlignment = textAnchor;
            UnityEngine.Canvas.ForceUpdateCanvases();
            return this;
        }
        
        public CanvasLayoutBuilder Columns (int number,Vector2 spacing,Vector2 cellSize,TextAnchor textAnchor)
        {
            GridLayoutGroup gridLayoutGroup = canvas.AddComponent<GridLayoutGroup>();
            gridLayoutGroup.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
            gridLayoutGroup.constraintCount = number;
            gridLayoutGroup.spacing = spacing;
            gridLayoutGroup.cellSize = cellSize;
            gridLayoutGroup.childAlignment = textAnchor;
            UnityEngine.Canvas.ForceUpdateCanvases();
            //canvas.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical,gridLayoutGroup.minHeight);
            //canvas.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,gridLayoutGroup.minWidth);
            return this;
        }
    }
}