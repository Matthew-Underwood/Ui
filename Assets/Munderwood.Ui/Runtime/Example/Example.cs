using Munderwood.Ui.Controller;
using Munderwood.Ui.Scene;

namespace Munderwood.Ui.Example
{
    public class Example : IBootstrap
    {
        public void Init(BootStrap bootStrap)
        {
            bootStrap.AddController("Project.Test.TestController","Test", new object[]{});
        }
    }
}