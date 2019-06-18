using Munderwood.UI;
using Munderwood.UI.Controller;
using UnityEngine;
using UnityEngine.Events;

namespace Project.Test
{
    public class TestController : MonoBehaviour
    {
        public void UnitPanel()
        {
            Ui.Template("Project.Test.TestTemplate");
        }
    }
}