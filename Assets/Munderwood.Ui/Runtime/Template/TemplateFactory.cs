using System;
using System.Collections.Generic;
using Munderwood.Core.Resolver;

namespace Munderwood.Ui.Template
{
    public class TemplateFactory
    {
        private readonly Dictionary<string, ITemplate> _templateRegistry;

        public TemplateFactory(Dictionary<string, ITemplate> templateRegistry)
        {
            _templateRegistry = templateRegistry;
        }
        
        public ITemplate CreateTemplate(Type type)
        {
            if (_templateRegistry.ContainsKey(type.ToString()))
            {
                return _templateRegistry[type.ToString()];
            }
            
            TypeResolver typeResolver = new TypeResolver();
            ITemplate template = (ITemplate) typeResolver.Resolve(type,new object[] {});
            
            _templateRegistry.Add(type.ToString(), template);
            return template;
        }
    }
}