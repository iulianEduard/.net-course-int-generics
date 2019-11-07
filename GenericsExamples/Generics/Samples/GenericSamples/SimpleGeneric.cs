namespace Generics.Samples.GenericSamples
{
    public class SimpleGeneric<T>
    {
        private T data;

        public T Data { get => data; set => data = value; }
    }
}
