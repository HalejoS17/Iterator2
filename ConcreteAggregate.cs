using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class ConcreteAggregate<T> : Aggregate<T>
    {
        private List<T> _collection;

        public ConcreteAggregate()
        {
            _collection = new List<T>();
        }

        public void AddItem(T item)
        {
            _collection.Add(item);
        }

        public Iterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(_collection);
        }
    }

}
