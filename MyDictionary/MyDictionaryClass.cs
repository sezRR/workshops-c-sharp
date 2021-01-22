using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionaryClass<TKey, TValue>
    {
        public TKey[] _keys;
        public TValue[] _values;

        public MyDictionaryClass()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = _keys;
            TValue[] tempValues = _values;

            _keys = new TKey[tempKeys.Length + 1];
            _values = new TValue[tempValues.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                _keys[i] = tempKeys[i];
            }

            _keys[_keys.Length - 1] = key;

            for (int i = 0; i < tempValues.Length; i++)
            {
                _values[i] = tempValues[i];
            }

            _values[_values.Length - 1] = value;
        }

        public int Count
        {
            get { return _keys.Length; }
        }
    }
}
