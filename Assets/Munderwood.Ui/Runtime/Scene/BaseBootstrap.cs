using Munderwood.Ui.Boostrapper;
using Munderwood.Ui.Controller;

namespace Munderwood.Ui.Scene
{
    public class BaseBootstrap 
    {
        public RegistryManager RegistryManager { get; set; }
        public ControllerFactory ControllerFactory { get; set; }

        public virtual void Init()
        {
            
        }
    }
}