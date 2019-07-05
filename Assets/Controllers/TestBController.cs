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
        public void NoArgsMethod()
        {
            Debug.Log("No args method invoked");
        }
        public void OneArgMethod(string val1)
        {
            Debug.Log("Hello " + val1);
        }
        public void TwoArgsMethod(string val1, double val2)
        {
            Debug.Log("Hello " + val1 + " " + val2.ToString());
        }
        public void ThreeArgsMethod(string val1, double val2, int val3)
        {
            Debug.Log("Hello " + val1 + " " + val2.ToString() + " " + val3.ToString());
        }
        public void FourArgsMethod(double val1,string val2, int val3, string val4)
        {
            Debug.Log("Hello " + val1.ToString() + " " + val2 + " " + val3.ToString() + " " + val4);
        }
    }
}