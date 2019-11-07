using Generics.Config;
using Generics.Samples.BuildInGenericsSamples;
using Generics.Samples.GenericSamples;
using Generics.Samples.LinqSamples;
using System;

namespace Generics
{
    class Program
    {
        static void Main()
        {
            SimpleGenericExample();

            AdvancedGenericExample();

            MethodsGenericExample();

            GenericListExample();

            GenericDictionaryExample();

            BasicLinqExample();

            GenericTypeLinqExample();

            DataJoinLinqExample();

            DataTransformationLinqExample();
        }

        private static void SimpleGenericExample()
        {
            SimpleGeneric<int> simpleGeneric = new SimpleGeneric<int>
            {
                Data = 222
            };

            string message = "Display data from generic";
            Console.WriteLine(message);
            Console.WriteLine(simpleGeneric.Data);

            Console.ReadKey();
        }

        private static void AdvancedGenericExample()
        {
            var customer = SampleData.InitCustomer();
            var genericCustomer = new AdvancedGeneric<Customer>();

            genericCustomer.CountProperties(customer);
            genericCustomer.DisplayProperties(customer);

            var transactions = SampleData.InitTransaction();
            var genericTransaction = new AdvancedGeneric<Transaction>();

            genericTransaction.CountProperties(transactions);
            genericTransaction.DisplayProperties(transactions);

            Console.ReadKey();
        }

        private static void MethodsGenericExample()
        {
            int a = 2, b = 5;

            Console.WriteLine($"a = {a}, b = {b}");
            MethodsGeneric.Swap<int>(ref a, ref b);
            Console.WriteLine($"a = {a}, b = {b}");

            string firstWord = "word 1", secondWord = "word 2";

            Console.WriteLine($"firstWord = {firstWord}, secondWord = {secondWord}");
            MethodsGeneric.Swap<string>(ref firstWord, ref secondWord);
            Console.WriteLine($"firstWord = {firstWord}, secondWord = {secondWord}");

            Console.ReadKey();
        }

        private static void GenericListExample()
        {
            var genericList = new GenericList();
            genericList.Run();

            Console.ReadKey();
        }

        private static void GenericDictionaryExample()
        {
            var genericDictionary = new GenericDictionary();
            genericDictionary.Run();

            Console.WriteLine("EOF");
            Console.ReadKey();
        }

        private static void BasicLinqExample()
        {
            var basicLinq = new BasicLinq();
            basicLinq.Run();

            Console.ReadKey();
        }

        private static void GenericTypeLinqExample()
        {
            var genericTypeLinq = new GenericTypeLinq();
            genericTypeLinq.Run();

            Console.ReadKey();
        }

        private static void DataJoinLinqExample()
        {
            var dataTransformationLinq = new DataJoinLinq();
            dataTransformationLinq.Run();

            Console.ReadKey();
        }

        private static void DataTransformationLinqExample()
        {
            var dataTransformationLinq = new DataTransformationLinq();
            dataTransformationLinq.Run();

            Console.ReadKey();
        }
    }
}
