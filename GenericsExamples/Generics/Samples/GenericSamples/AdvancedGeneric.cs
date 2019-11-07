using System;

namespace Generics.Samples.GenericSamples
{
    public class AdvancedGeneric<T> where T : class
    {
        public void CountProperties(T model)
        {
            if (model == null)
                return;

            var properties = model.GetType().GetProperties();

            Console.WriteLine($"Model typeof: {model.GetType()} has {properties.Length} properties");
            Console.WriteLine(Environment.NewLine);
        }

        public void DisplayProperties(T model)
        {
            if (model == null)
                return;

            var properties = model.GetType().GetProperties();

            Console.WriteLine($"Model typeof: {model.GetType()} has the following properties and values:");
            foreach(var property in properties)
            {
                Console.WriteLine($"--> Name: {property.Name}, value: {property.GetValue(model)}");
            }

            Console.WriteLine(Environment.NewLine);
        }
    }
}
