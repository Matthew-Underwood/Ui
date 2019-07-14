using System.Collections.Generic;
using Project.Test;

namespace Munderwood.UI.Template
{
    public class TemplateFactory
    {
        private readonly TemplateRegistry _templateRegistry;

        public TemplateFactory(TemplateRegistry templateRegistry)
        {
            _templateRegistry = templateRegistry;
        }
        
        public ITemplate CreateTemplate(string name)
        {
            if (_templateRegistry.Contains(name))
            {
                return _templateRegistry.Get(name);
            }
            
            TypeResolver typeResolver = new TypeResolver();
            ITemplate template = (ITemplate) typeResolver.Resolve(name,new object[] {});
            _templateRegistry.Add(name, template);
            return template;
        }
    }
}