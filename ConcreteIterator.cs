using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class ConcreteIterator<T> : Iterator<T>
    {
        private List<T> _collection;
        private int _index;

        public ConcreteIterator(List<T> collection)
        {
            _collection = collection;
            _index = 0;
        }

        public bool HasNext()
        {
            return _index < _collection.Count;
        }

        public T Next()
        {
            T item = _collection[_index];
            _index++;
            return item;
        }
    }

}
