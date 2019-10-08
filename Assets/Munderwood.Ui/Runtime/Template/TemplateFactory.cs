using System.Collections.Generic;
using Project.Test;
using UnityEngine.EventSystems;

namespace Munderwood.Ui.Template
{
    public class TemplateFactory
    {
        private readonly Dictionary<string, ITemplate> _templateRegistry;

        public TemplateFactory(Dictionary<string, ITemplate> templateRegistry)
        {
            _templateRegistry = templateRegistry;
        }
        
        public ITemplate CreateTemplate(string name)
        {
            if (_templateRegistry.ContainsKey(name))
            {
                return _templateRegistry[name];
            }
            
            TypeResolver typeResolver = new TypeResolver();
            ITemplate template = (ITemplate) typeResolver.Resolve(name,new object[] {});
            
            _templateRegistry.Add(name, template);
            return template;
        }
    }
}