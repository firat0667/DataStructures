using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAlgorithms.HashTable
{
    internal class HashTable
    {
        public string[] _hashTable { get; set; }

        public HashTable()
        {
            _hashTable = new string[10];
        }
        private int Hash(string key)
        {
            return key.Length % _hashTable.Length;
        }
     
        public string Get (string key)
        {
            int hashedKey=Hash(key);
            return _hashTable[hashedKey];
        }
        public void Set(string key,string value)
        {
            int hashedKey = Hash(key);
            if (_hashTable[hashedKey] != null)
            {
                Console.WriteLine("Sorry,hash collison has occured");
            }
            else
            {
                _hashTable[hashedKey] = value;
            }
        }
    }
}
