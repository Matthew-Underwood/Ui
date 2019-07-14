using System.Collections.Generic;
using Project.Test;
using UnityEngine;

namespace Munderwood.UI.Template
{
    public class TemplateRegistry
    {
        protected Dictionary<string, ITemplate> templates = new Dictionary<string, ITemplate>();

        public void Add (string name, ITemplate template)
        {
            templates.Add(name,template);
        }
        
        public bool Contains (string name)
        {
            return templates.ContainsKey(name);
        }
        
        public ITemplate Get (string name)
        {
            return templates[name];
        }
    }
}