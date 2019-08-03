using Munderwood.UI.Event;
using UnityEngine;

namespace Munderwood.UI.Action
{
    public class ButtonActionFactory
    {
        private readonly GameObject _button;

        public ButtonActionFactory(GameObject button)
        {
            _button = button;
        }
        public IEventInvoker CreateClickAction()
        {
            return _button.AddComponent<ClickAction>();
        }
        
        public IEventInvoker CreateHoverAction()
        {
            return _button.AddComponent<HoverAction>();
        }
    }
}