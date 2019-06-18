using Boo.Lang.Runtime;
using Munderwood.UI.Event.Click;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class ClickAction : MonoBehaviour , IPointerUpHandler
{
    public UnityEvent clickEventNoArgs;
    public ClickEventOneArg clickEventOneArg;
    public ClickEventTwoArgs clickEventTwoArgs;
    public ClickEventThreeArgs clickEventThreeArgs;
    public ClickEventFourArgs clickEventFourArgs;
    public string firstArg;
    public string secondArg;
    public string thirdArg;
    public string fourthArg;
    
    public void OnPointerUp(PointerEventData eventData)
    {
        if (clickEventNoArgs != null)
        {
            clickEventNoArgs.Invoke();
        } else if (clickEventOneArg != null)
        {
            clickEventOneArg.Invoke(this.firstArg);
        } else if (clickEventTwoArgs != null)
        {
            clickEventTwoArgs.Invoke(this.firstArg,this.secondArg);
        } else if (clickEventThreeArgs != null)
        {
            clickEventThreeArgs.Invoke(this.firstArg,this.secondArg,this.thirdArg);
        } else if (clickEventFourArgs != null)
        {
            clickEventFourArgs.Invoke(this.firstArg,this.secondArg,this.thirdArg,this.fourthArg);
        }
        else
        {
            throw new RuntimeException("No event setup with this " + this.name);
        }
    }
}

