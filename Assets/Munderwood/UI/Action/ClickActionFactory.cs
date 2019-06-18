using UnityEngine;

namespace Munderwood.UI.Action
{
    public class ClickActionFactory
    {
        public ClickAction Create(GameObject button)
        {
            return button.AddComponent<ClickAction>();
        }
    }
}