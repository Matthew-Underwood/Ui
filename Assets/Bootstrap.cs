using Munderwood.Test;
using UnityEngine;
using Munderwood.UI;
public class Bootstrap : MonoBehaviour
{
    private void Start()
    {
        UiService uiService = new UiService();
        uiService.Build();
        Ui.AddController("Project.Test.TestController", "UnitPanel");
    }
}
