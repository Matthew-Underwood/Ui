using Munderwood.Ui.Invoker;

namespace Munderwood.Ui
{
    public class RegistryManagerFactory
    {
        public RegistryManager Create()
        {
            RegistryManager registryManager = new RegistryManager();
            return registryManager;
        }
    }
}