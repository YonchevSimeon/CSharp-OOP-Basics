namespace CollectionHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string[] addElements = Console.ReadLine().Split();
            int removingElementsCount = int.Parse(Console.ReadLine());

            AddCollection<string> addCollection = new AddCollection<string>();
            AddRemoveCollection<string> addRemoveCollection = new AddRemoveCollection<string>();
            MyList<string> myList = new MyList<string>();

            List<int> addCollectionIndices = new List<int>();
            List<int> addRemoveCollectionIndices = new List<int>();
            List<int> myListIndices = new List<int>();
            List<string> addRemoveCollectionRemoved = new List<string>();
            List<string> myListRemoved = new List<string>();
            
            int indexOfAddCollection;
            int indexOfAddRemoveCollection;
            int indexOfMyList;

            foreach (string element in addElements)
            {
                indexOfAddCollection = addCollection.Add(element);
                addCollectionIndices.Add(indexOfAddCollection);

                indexOfAddRemoveCollection = addRemoveCollection.Add(element);
                addRemoveCollectionIndices.Add(indexOfAddRemoveCollection);

                indexOfMyList = myList.Add(element);
                myListIndices.Add(indexOfMyList);
            }

            string removedElementFromAddRemoveCollection;
            string removedElementFromMyList;

            for (int curr = 0; curr < removingElementsCount; curr++)
            {
                removedElementFromAddRemoveCollection = addRemoveCollection.Remove();
                addRemoveCollectionRemoved.Add(removedElementFromAddRemoveCollection);

                removedElementFromMyList = myList.Remove();
                myListRemoved.Add(removedElementFromMyList);
            }

            Console.WriteLine(string.Join(" ", addCollectionIndices));
            Console.WriteLine(string.Join(" ", addRemoveCollectionIndices));
            Console.WriteLine(string.Join(" ", myListIndices));
            Console.WriteLine(string.Join(" ", addRemoveCollectionRemoved));
            Console.WriteLine(string.Join(" ", myListRemoved));
        }
    }
}
