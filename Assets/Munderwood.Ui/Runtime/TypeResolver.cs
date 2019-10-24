using System;

namespace Munderwood.Ui
{
    public class TypeResolver
    {
        public object Resolve(Type type, object[] arguments)
        {
           object resolvedType = Activator.CreateInstance(type,arguments);
           return resolvedType;
        }
    }
}