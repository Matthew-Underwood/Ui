using Munderwood.Events;
using UnityEngine;

namespace Munderwood.Ui.Action
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