namespace Munderwood.Ui.Invoker
{
    public interface ITypeInvoker
    {
        void CallMethod(object type, string name, object[] parameters);
    }
}