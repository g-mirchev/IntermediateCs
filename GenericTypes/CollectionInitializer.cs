using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    /*
     * A class to represent a collection of generic types
     */
    public class CollectionInitializer<T>
    {
        private T[] collection;     //Create an array of generic type
        public uint CollectionLength { get; private set; }      //store the originally declared length

        /*
         * Declare the length of the collection and store it while creating an
         * empty array of declared generic type
         */
        public CollectionInitializer(uint collectionLength)
        {
            collection = new T[collectionLength];
            CollectionLength = collectionLength;
        }

        /*
         * If items parsed are not more than the declared collection length
         * add them to the collection. This will override any previous collection
         */
        public void AddElementsToCollection(params T[] elements)
        {
            if (elements.Length <= CollectionLength)
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    collection[i] = elements[i];
                }
            }
            else
            {
                Console.WriteLine($"Number of parameters can not exceed {CollectionLength}");
            }
        }

        /*
         * Returns the collection
         */
        public T[] RetrieveAllElements()
        {
            return collection;
        }

        /*
         * Returns the item from this collection corresponding to the index
         * if the index is within the bounds of the collection
         */
        public T RetrieveElementOnIndex(uint index)
        {
            if (index < CollectionLength)
            {
                return collection[index];
            }
            else
            {
                Console.WriteLine($"Index must be between 0 and {CollectionLength - 1}");
                return default;
            }
        }
    }
}
