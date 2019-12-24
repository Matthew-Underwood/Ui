using System;
using System.Linq;
using System.Reflection;
using Munderwood.Core.Invoker;
using Munderwood.Ui.Controller;
using Munderwood.Ui.Scene;
using UnityEngine;

namespace Munderwood.Ui.Bootstrap
{
    public class Init : MonoBehaviour
    {
        public void Start()
        {
            var bootstrapType = typeof(IBootstrap);
            var types = AppDomain.CurrentDomain.GetAssemblies().
                 SelectMany(s => s.GetTypes()).
                 Where(p => bootstrapType.IsAssignableFrom(p) && !p.IsInterface);
            
            //TODO limit 1 and fetch as single row
            foreach (var type in types)
            {
                RegistryManager registryManager = (new RegistryManagerFactory()).Create();
                BasicTypeInvoker basicTypeInvoker = new BasicTypeInvoker();
                ControllerFactory controllerFactory = new ControllerFactory(registryManager,basicTypeInvoker);
                BootStrap bootstrap = new BootStrap(registryManager,controllerFactory,basicTypeInvoker);
                object example = Activator.CreateInstance(type,new object[]{});
                MethodInfo initMethod = example.GetType().GetMethod("Init");
                if (initMethod != null)
                {
                    initMethod.Invoke(example,new object[] {bootstrap});    
                }
            }
        }
    }
}