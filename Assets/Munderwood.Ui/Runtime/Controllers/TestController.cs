using Munderwood.Ui.Controller;
using UnityEngine;

namespace Project.Test
{
    public class TestController : BaseController
    {
        public void Test()
        {
            Template("Munderwood.Ui.Template.TestTemplate");
        }
        
        public void Hello()
        {
            Debug.Log("Hello there");
        }
    }
}