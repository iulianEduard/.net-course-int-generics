namespace Generics.Samples.GenericSamples
{
    public static class MethodsGeneric
    {
        /*
         * Generic methods must be static
         */
        public static void Swap<T>(ref T firstValue, ref T secondValue)
        {
            T temp;
            temp = firstValue;
            firstValue = secondValue;
            secondValue = temp;
        }
    }
}
