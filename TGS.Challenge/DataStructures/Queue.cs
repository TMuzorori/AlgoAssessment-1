using System;

namespace TGS.Challenge.DataStructures
{
    public class Queue<T>
    {
        private T[] _items;
        private int rear, front;
        public int Count
        {
            get { return this._items.Length; }
        }

        public Queue()
        {
            this._items = new T[] { };
            this.rear = 0;
            this.front = 0;
        }

        public void Enqueue(T item)
        {

            if (rear == _items.Length)
            {
                Array.Resize(ref this._items, this._items.Length + 1);
            }
            _items[rear] = item;
            rear++;


        }

        public T Peek()
        {
            // return this._items.Length > 0 ? this._items[this._items.GetUpperBound(0)] : default(T);
            if (_items.Length == 0)
                throw new InvalidOperationException("Exception: Empty stack");

            return _items[front];
        }

        public T Dequeue()
        {
            if (this._items.Length == 0)
            {
                return default(T);
            }

            // var result = (T)this._items.GetValue(this._items.GetUpperBound(0));
            else
            {
                var item = this._items[this.front];
                if (this.front == _items.Length)
                {
                    this.front = 1;
                }
                else
                {
                    this.front = this.front + 1;
                }
                Array.Resize(ref this._items, this._items.Length - 1);
                return item;



            }
        }

        public void Clear()
        {
            this._items = new T[0];
        }
    }
}
