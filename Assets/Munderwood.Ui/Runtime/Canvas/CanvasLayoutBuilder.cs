using Munderwood.UI.Controller;
using UnityEngine;
using UnityEngine.UI;

namespace Munderwood.UI.Canvas
{
    public class CanvasLayoutBuilder : CanvasBuilder
    {
        public CanvasLayoutBuilder(GameObject canvas, ControllerResolver controllerResolver,CanvasDimensionsTransformer canvasDimensionsTransformer) : base(canvas,controllerResolver,canvasDimensionsTransformer) 
        {
            this.canvas = canvas;
            this.controllerResolver = controllerResolver;
            this.canvasDimensionsTransformer = canvasDimensionsTransformer;
        }
        
        public CanvasLayoutBuilder Horizontal (float spacing,RectOffset padding)
        {
            HorizontalLayoutGroup gridLayoutGroup = canvas.AddComponent<HorizontalLayoutGroup>();
            gridLayoutGroup.spacing = spacing;
            gridLayoutGroup.padding = padding;
            //canvasDimensionsTransformer.SetWidth(gridLayoutGroup.minWidth);
            //canvasDimensionsTransformer.SetHeight(gridLayoutGroup.minHeight);
            return this;
        }
        
        public CanvasLayoutBuilder Vertical (float spacing,RectOffset padding)
        {
            VerticalLayoutGroup gridLayoutGroup = canvas.AddComponent<VerticalLayoutGroup>();
            gridLayoutGroup.spacing = spacing;
            gridLayoutGroup.padding = padding;
            UnityEngine.Canvas.ForceUpdateCanvases();
            canvas.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical,gridLayoutGroup.minHeight);
            canvas.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,gridLayoutGroup.minWidth);
            //canvasDimensionsTransformer.SetWidth(gridLayoutGroup.minWidth);
            //canvasDimensionsTransformer.SetHeight(gridLayoutGroup.minHeight);
            return this;
        }

        public CanvasLayoutBuilder Rows (int number,Vector2 spacing,Vector2 cellSize)
        {
            GridLayoutGroup gridLayoutGroup = canvas.AddComponent<GridLayoutGroup>();
            gridLayoutGroup.constraint = GridLayoutGroup.Constraint.FixedRowCount;
            gridLayoutGroup.constraintCount = number;
            gridLayoutGroup.spacing = spacing;
            gridLayoutGroup.cellSize = cellSize;
            UnityEngine.Canvas.ForceUpdateCanvases();
            canvas.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical,gridLayoutGroup.minHeight);
            canvas.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,gridLayoutGroup.minWidth);
            //canvasDimensionsTransformer.SetWidth(gridLayoutGroup2.minWidth);
            //canvasDimensionsTransformer.SetHeight(gridLayoutGroup2.minHeight);
            return this;
        }
        
        public CanvasLayoutBuilder Columns (int number,Vector2 spacing,Vector2 cellSize)
        {
            GridLayoutGroup gridLayoutGroup = canvas.AddComponent<GridLayoutGroup>();
            gridLayoutGroup.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
            gridLayoutGroup.constraintCount = number;
            gridLayoutGroup.spacing = spacing;
            gridLayoutGroup.cellSize = cellSize;
            UnityEngine.Canvas.ForceUpdateCanvases();
            canvas.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical,gridLayoutGroup.minHeight);
            canvas.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,gridLayoutGroup.minWidth);
            //canvasDimensionsTransformer.SetWidth(gridLayoutGroup.minWidth);
            //canvasDimensionsTransformer.SetHeight(gridLayoutGroup.minHeight);
            return this;
        }
    }
}