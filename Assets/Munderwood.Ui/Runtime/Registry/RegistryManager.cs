using System.Collections.Generic;
using Munderwood.Ui.Template;
using UnityEngine;

namespace Munderwood.Ui
{
    public class RegistryManager
    {
        public Dictionary<string, GameObject> ControllerRegistry { get; } = new Dictionary<string, GameObject>();
        public Dictionary<string, ITemplate> TemplateRegistry { get; } = new Dictionary<string, ITemplate>();
    }
}