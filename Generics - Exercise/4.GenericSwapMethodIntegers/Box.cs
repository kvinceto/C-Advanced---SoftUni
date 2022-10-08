namespace GenericSwapMethodIntegers
{
    public class Box<T>
    {
        private T item;

        public Box(T element)
        {
            item = element;
        }

        public override string ToString()
        {
            string s = $"{item.GetType()}: {item.ToString()}";
            return s;
        }
    }
}
