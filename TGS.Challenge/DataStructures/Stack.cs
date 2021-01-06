using System;
using System.Collections;



namespace TGS.Challenge.DataStructures
{
    public class Stack<T>
    {
        private T[] _items;

        private int index;


        public int Count
        {
            get { return this._items.Length; }
        }

        public Stack()
        {
            this._items = new T[] { };

            this.index = 0;

        }

        public void Push(T value)
        {
            if (index == _items.Length)
            {
                Array.Resize(ref this._items, this._items.Length + 1);
            }
            _items[index] = value;
            index++;

        }

        public T Peek()
        {
            if (index == 0)
                throw new InvalidOperationException("Exception: Empty stack");

            return _items[index - 1];


        }

        public T Pop()
        {

            if (index == 0)
            {
                throw new InvalidOperationException("Exception: Empty stack");
            }
            else
            {
                var poppeditem = _items[--index];
                Array.Resize(ref this._items, this._items.Length - 1);
                return poppeditem;
            }

        }
        public void Clear()
        {
            this._items = new T[0];

        }
    }
}