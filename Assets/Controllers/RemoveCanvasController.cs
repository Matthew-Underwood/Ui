using System.Collections.Generic;
using Munderwood.UI;
using Munderwood.UI.Controller;
using UnityEngine;

namespace Project.Test
{
    public class RemoveCanvasController : BaseController
    {
        public void RemoveCanvases(int level)
        {
            GameObject[] canvases = GameObject.FindGameObjectsWithTag("Canvas");
            foreach (GameObject canvas in canvases)
            {
                if (canvas.GetComponent<CanvasMeta>().Level == level)
                {
                    Object.Destroy(canvas);
                }
            }
        }
    }
}