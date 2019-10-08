using System;

namespace Munderwood.Ui
{
    public class TypeResolver
    {
        public object Resolve(string name, object[] arguments)
        {
           object resolvedType = Activator.CreateInstance(System.Type.GetType(name),arguments);
           return resolvedType;
        }
    }
}