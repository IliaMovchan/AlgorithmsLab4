using System;
namespace ADT
{
    public interface ICursorList<T>
    {
        void Next();
        void Previous();
        T getCurrent();
        void RemoveCurrent();
        void Clear();
        void AddToCursor(T val);
        void AddToEnd(T val);
        void MoveToFirst();
        void MoveToLast();
    }

    public class CursorList<T> : ICursorList<T>
    {
        List<T> elements;
        public int Cursor { get; private set; }
        public int Count { get; private set; }

        public CursorList()
        {
            elements = new List<T>();
            Cursor = 0;
            Count = 0;
        }

        public void AddToCursor(T val)
        {
            elements.Insert(Cursor, val);
            Count++;
        }

        public void AddToEnd(T val)
        {
            elements.Add(val);
            Count++;
        }

        public void Clear()
        {
            elements.Clear();
            Count = 0;
        }

        public T getCurrent()
        {
            if (Cursor >= 0 && Cursor <= elements.Count - 1)
            {
                return elements[Cursor];
            }
            return default(T);
        }

        public void Next()
        {
            if (Cursor != elements.Count - 1) Cursor++;
        }

        public void Previous()
        {
            if (Cursor != 0) Cursor--;
        }

        public void RemoveCurrent()
        {
            if (Cursor >= 0 && Cursor <= elements.Count - 1)
            {
                elements.RemoveAt(Cursor);
                Count--;
            }
        }

        public void MoveToFirst()
        {
            Cursor = 0;
        }

        public void MoveToLast()
        {
            Cursor = elements.Count - 1;
        }
    }
}

