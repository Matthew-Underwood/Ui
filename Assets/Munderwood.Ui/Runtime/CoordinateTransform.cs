using UnityEngine;

namespace Munderwood.Ui
{
    public static class CoordinateTransform
    {
        public static Vector2 InverseYCoordinate(Vector2 position)
        {
            Vector2 tempCoordinates = new Vector2(position.x,-position.y);
            return tempCoordinates;
        }
        
        public static Vector2 ParentCanvasTransform(Vector2 position, Vector2 offsetPosition)
        {
            Vector2 localPoint;
            GameObject masterCanvas = GameObject.Find("masterCanvas");
            Vector2 anchoredPosition = masterCanvas.GetComponent<RectTransform>().anchoredPosition;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(masterCanvas.GetComponent<RectTransform>(),position,null,out localPoint);
            return new Vector2(localPoint.x + anchoredPosition.x + offsetPosition.x, -localPoint.y + anchoredPosition.y + offsetPosition.y);
        }
    }
}