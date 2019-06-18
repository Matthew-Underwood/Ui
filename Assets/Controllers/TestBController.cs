using Munderwood.UI;
using UnityEngine;

namespace Project.Test
{
    public class TestBController : MonoBehaviour
    {
        public void UnitPanel()
        {
            Ui.Template("Project.Test.Test2Template");
        }
        public void TestHello(string val1,string val2,string val3)
        {
            Debug.Log("Hello " + val1 + " " + val2 + " " + val3 + ".");
        }
    }
}