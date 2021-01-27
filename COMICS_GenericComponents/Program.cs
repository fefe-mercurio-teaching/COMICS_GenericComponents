using System;

namespace COMICS_GenericComponents
{
    class Program
    {
        static void Main(string[] args)
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<Rigidbody>();

            Console.WriteLine(gameObject.CountComponents());
            gameObject.PrintAllComponents();

            Console.WriteLine();
            gameObject.AddComponent<Collider>();
            gameObject.PrintAllComponents();

            Collider collider = gameObject.GetComponent<Collider>();
        }
    }
}
