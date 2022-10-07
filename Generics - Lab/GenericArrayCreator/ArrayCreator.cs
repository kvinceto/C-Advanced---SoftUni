
namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T items)
        {
            T[] array = new T[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = items;
            }
            return array;
        }
    }
}
