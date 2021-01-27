using System;
using System.Collections.Generic;

namespace COMICS_GenericComponents
{
    public class GameObject
    {
        List<Component> components = new List<Component>();

        public T AddComponent<T>() where T : Component, new()
        {
            T newComponent = new T();
            components.Add(newComponent);

            return newComponent;
        }

        public T GetComponent<T>() where T : Component
        {
            foreach(Component component in components)
            {
                if (component.GetType() == typeof(T))
                {
                    return (T)component;
                }
            }

            return null;
        }

        public int CountComponents() => components.Count;

        public void PrintAllComponents()
        {
            foreach(Component component in components)
            {
                Console.WriteLine("- " + component.GetType());
            }
        }
    }
}
