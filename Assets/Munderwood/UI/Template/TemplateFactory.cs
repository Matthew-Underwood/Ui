using System.Collections.Generic;
using Project.Test;

namespace Munderwood.UI.Template
{
    public class TemplateFactory
    {
        protected Dictionary<string, ITemplate> templates = new Dictionary<string, ITemplate>();
        protected TypeResolver TypeResolver;
        
        public ITemplate CreateTemplate(string name)
        {
            if (templates.ContainsKey(name))
            {
                return templates[name];
            }
            
            TypeResolver typeResolver = new TypeResolver();
            object[] arguments = {};
            ITemplate template = (ITemplate) typeResolver.Resolve(name,arguments);
            templates.Add(name, template);
            return template;
        }
    }

}