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
        
        public IEventInvoker CreateHoverInAction()
        {
            return _button.AddComponent<HoverInAction>();
        }
        
        public IEventInvoker CreateHoverOutAction()
        {
            return _button.AddComponent<HoverOutAction>();
        }
    }
}