namespace GenericClass
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;


    public class GenericList<T> : IEnumerable<T>
        where T : IComparable
    {
        private const int StartCapacity = 4;
        private T[] elements;

        public GenericList()
        {
            this.Capacity = StartCapacity;
            this.elements = new T[Capacity];           
        }

        public int Capacity { get; private set; }
        public int Count { get; private set; }


        public int IndexOf(T element)
        {
            var position = -1;

            for(int i = 0; i < this.Capacity; i++)
            {
                if(this.elements[i].CompareTo(element) == 0)
                {
                    position = i;
                    break;
                }
            }
            return position;
        }

        public void Add(T element)
        {
            if (this.Count == this.Capacity)
            {
                this.ReSize();
            }

            this.elements[this.Count] = element;
            this.Count++;
        }

        private void ReSize()
        {
            var oldElements = this.elements;
            this.Capacity *= 2;
            this.elements = new T[Capacity];
            Array.Copy(oldElements, this.elements, this.Count);
        }

        public void Insert(T element, int position)
        {
            if(position >= 0 && position < this.Count)
            {
                this.Count++;
                if (this.Count == this.Capacity)
                {
                    this.ReSize();
                }
                var temp = this.elements;
                this.elements = new T[Capacity];
                int flag = 0;
                for(int i = 0; i < this.Count; i++)
                {
                    if(i == position)
                    {
                        this.elements[i] = element;
                        flag = 1;
                        continue;
                    }
                    this.elements[i] = temp[i - flag];
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void Clear()
        {
            this.Capacity = StartCapacity;
            this.elements = new T[Capacity];
            this.Count = 0;
        }

        public T FindAt(int position)
        {
            if (position >= 0 && position < this.Capacity)
            {
                return this.elements[position];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void RemoveAt(int position)
        {
            if(position >= 0 && position < this.Capacity)
            {
                var temp = this.elements;
                this.elements = new T[Capacity];
                Array.Copy(temp, this.elements, position);
                for(int i = position; i < this.Count - 1; i++)
                {
                    this.elements[i] = temp[i + 1]; 
                }
                this.Count--;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            for(int i = 0; i < this.Count; i++)
            {
                result.AppendFormat("{0}, ", this.elements[i]);              
            }
            return result.ToString().TrimEnd(',', ' ');
        }

        public T Min()
        {           
            if (this.Count > 0)
            {
                var temp = this.elements[0];
                for (int i = 1; i < this.Count; i++)
                {
                    if(temp.CompareTo(this.elements[i]) > 0)
                    {
                        temp = this.elements[i];
                    }
                }
                return temp;
            }    
            else
            {
                throw new IndexOutOfRangeException();
            }       
        }

        public T Max()
        {            
            if (this.Count > 0)
            {
                var temp = this.elements[0];
                for (int i = 1; i < this.Count; i++)
                {
                    if (temp.CompareTo(this.elements[i]) < 0)
                    {
                        temp = this.elements[i];
                    }
                }
                return temp;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
