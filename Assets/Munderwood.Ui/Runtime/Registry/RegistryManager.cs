using System.Collections.Generic;
using Munderwood.Ui.Invoker;
using Project.Test;
using UnityEngine;

namespace Munderwood.Ui
{
    public class RegistryManager
    {
        public Dictionary<string, GameObject> ControllerRegistry { get; } = new Dictionary<string, GameObject>();

        public Dictionary<string, ITemplate> TemplateRegistry { get; } = new Dictionary<string, ITemplate>();

        public Dictionary<string, ITypeInvoker> InvokerRegistry { get; } = new Dictionary<string, ITypeInvoker>();
        
       
    }
}