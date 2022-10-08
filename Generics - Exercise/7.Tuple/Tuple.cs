namespace Tuple
{
    public class Tuple <T, V>
    {
        private T item1;
        private V item2;

        public T Item1 { get { return item1; } }
        public V Item2 { get { return item2;} }
        public Tuple(T item1, V item2)
        {
            this.item1 = item1;
            this.item2 = item2;
        }
    }
}
