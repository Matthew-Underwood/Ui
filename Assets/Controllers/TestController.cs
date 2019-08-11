using Munderwood.UI;
using Munderwood.UI.Controller;
using UnityEngine;
using UnityEngine.Events;

namespace Project.Test
{
    public class TestController : BaseController
    {
        public void UnitPanel()
        {
            //Ui.Template("Project.Test.TestTemplate");
            Template("Project.Test.TestTemplate");
        }

        public void Hello()
        {
            Debug.Log("Hello!");
        }
        
        public void HelloAgain()
        {
            Debug.Log("Hello again!");
        }
        
        public void HoverGreeting(string firstName, string surname)
        {
            Debug.Log("My name is " + firstName + " " + surname);
        }
        
    }
}