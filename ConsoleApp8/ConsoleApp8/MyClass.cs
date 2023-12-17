namespace ConsoleApp8
{
    public class Class1<T>
    {
        public T[] arr1;

        public Class1()
        {
            arr1 = new T[0];
        }
        public void Add(T obj)
        {
            Array.Resize(ref arr1, arr1.Length + 1);
            arr1[arr1.Length - 1] = obj;
        }
        public void ShowAll()
        {
            foreach (T obj in arr1)
            {
                Console.WriteLine(obj);
            }
        }
        public void Clear()
        {
            Array.Resize(ref arr1, 0);
        }
        public void CustomAddRange(List<T> list)
        {
            foreach (var item in list)
            {
                Add(item);
            }
        }
        public bool CustomContains(T obj)
        {
            foreach (var item in arr1)
            {
                if (Equals(item, obj))
                {
                    return true;
                }
            }
            return false;
        }
        public int FirstIndexOf(T obj)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (Equals(arr1[i], obj))
                {
                    Console.WriteLine(i);
                    return i;
                }
            }
            Console.WriteLine(-1);
            return -1;
        }
        public void Remove(T obj)
        {
            for (int i = 0; i <= arr1.Length - 1; i++)
            {
                if (Equals(arr1[i], obj))
                {
                    arr1[i] = default;
                    for (int j = i; j < arr1.Length - 1; j++)
                        arr1[j] = arr1[j + 1];
                    Array.Resize(ref arr1, arr1.Length - 1);
                }
            }
        }
    }
}