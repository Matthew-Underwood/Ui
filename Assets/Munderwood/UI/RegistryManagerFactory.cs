using Munderwood.UI.Invoker;

namespace Munderwood.UI
{
    public class RegistryManagerFactory
    {
        public RegistryManager Create()
        {
            RegistryManager registryManager = new RegistryManager();
            registryManager.InvokerRegistry.Add("BasicInvoker", new BasicTypeInvoker());
            registryManager.InvokerRegistry.Add("GameObjectInvoker", new GameObjectInvoker());
            return registryManager;
        }
    }
}