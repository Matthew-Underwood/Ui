using System;
using Munderwood.Ui.Controller;
using Munderwood.Ui.Scene;
using UnityEngine;

namespace Munderwood.Ui.Boostrapper
{
    public class Init : MonoBehaviour
    {
        public void Start()
        {
            RegistryManager registryManager = (new RegistryManagerFactory()).Create();
            ControllerFactory controllerFactory = new ControllerFactory(registryManager);
            BootStrap bootstrap = new BootStrap(registryManager,controllerFactory);
            object example = Activator.CreateInstance(typeof(Example.Example),new object[]{});
            Example.Example exampleNew = (Example.Example) example;
            exampleNew.Init(bootstrap);
        }
    }
}