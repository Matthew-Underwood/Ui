using UnityEngine;

namespace Munderwood.UI.Controller
{
    public class ControllerFactory
    {
        public GameObject CreateController(string name)
        {
            GameObject controllerGameObject = new GameObject();
            controllerGameObject.name = name;
            controllerGameObject.AddComponent(System.Type.GetType(name));
            return controllerGameObject;
        }
    }
}