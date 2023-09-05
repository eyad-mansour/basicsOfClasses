using System;
using System.Collections;
namespace LandingLibrary
{
    public interface IBag<T> : IEnumerable<T> 
    {
        void Pack(T item);

        T Unpack(int index);
    }
    public class BookPack<T> : IBag<T>
    {
        private readonly List<T> stuff = new List<T>();

        public void Pack(T item)
        {
            stuff.Add(item);
        }
        public T Unpack(int index)
        {
            T things = stuff[index];
            stuff.RemoveAt(index);
            return things;
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T thing in stuff)
                yield return thing;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}

