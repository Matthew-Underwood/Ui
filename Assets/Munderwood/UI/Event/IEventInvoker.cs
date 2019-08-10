namespace Munderwood.UI.Event
{
    public interface IEventInvoker
    {
        void SetEventInvoker(EventManager eventManager);
        void SetPointerDataEventInvoker(PointerDataEventManager pointerDataEventManager);
    }
}