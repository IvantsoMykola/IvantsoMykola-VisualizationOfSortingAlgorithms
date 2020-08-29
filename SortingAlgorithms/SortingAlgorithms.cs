using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class SortingAlgorithms
    {
        public static void Swap<T>(IList<T> items, int leftIndex, int rightIndex)
        {
            T tempItem = items[leftIndex];
            items[leftIndex] = items[rightIndex];
            items[rightIndex] = tempItem;
        }

        public static void BubbleSort<T>(IList<T> items) where T: IComparable<T>
        {
            if(items.Count == 0)
            {
                return;
            }
            bool swapped = true;
            while(swapped == true)
            {
                swapped = false;
                for (int i = 0, j = i + 1; j < items.Count ; i++, j++)
                {
                    if(items[i].CompareTo(items[j]) > 0)
                    {
                        Swap(items, i, j);
                        swapped = true;
                    }
                }
            }
        }

        public static void InsertionSort<T>(IList<T> items) where T : IComparable<T>
        {
            if (items.Count == 0)
            {
                return;
            }
            if(items[0].CompareTo(items[1]) > 0)
            {
                var tempItem = items[0];
                items[0] = items[1];
                items[1] = tempItem;
            }
            int lastSortedIndex = 1;
            for(int i = lastSortedIndex; i < items.Count - 1; i++)
            {
                if(items[i].CompareTo(items[i + 1]) > 0)
                {
                    var tempItem = items[i + 1];
                    for(int j = i; j >=0; j--)
                    {
                        if(tempItem.CompareTo(items[j]) < 0)
                        {
                            items[j + 1] = items[j];
                            items[j] = tempItem;
                        }
                    }
                }
            }
        }

        public static void SelectionSort<T>(IList<T> items) where T : IComparable<T>
        {
            int indexOfSmallest;
            try
            {
                indexOfSmallest = FindIndexOfSmallest(items);
            }
            catch (ArgumentException)
            {
                return;
            }
            catch
            {
                throw;
            }
            var tempValue = items[0];
            items[0] = items[indexOfSmallest];
            items[indexOfSmallest] = tempValue;
            for(int i = 1; i < items.Count; i++)
            {
                indexOfSmallest = FindIndexOfSmallest(items.Skip(i).ToList()) + i;
                tempValue = items[i];
                items[i] = items[indexOfSmallest];
                items[indexOfSmallest] = tempValue;
            }
        }

        public static int FindIndexOfSmallest<T>(IList<T> items) where T : IComparable<T>
        {
            if(items.Count == 0)
            {
                throw new ArgumentException("Collection is emtry");
            }
            int indexOfSmallest = 0;
            for(int i = 1; i < items.Count; i++)
            {
                if(items[i].CompareTo(items[indexOfSmallest]) < 0)
                {
                    indexOfSmallest = i;
                }
            }
            return indexOfSmallest;
        }

        //TODO Need better algorithm
        public static IList<T> MergeSort<T>(IList<T> items) where T : IComparable<T>
        {
            if(items.Count/2 > 0)
            {
                var left = MergeSort(items.Take(items.Count / 2).ToArray());
                var right = MergeSort(items.Skip(items.Count / 2).ToArray());

                int rightIndex = 0;
                int leftIndex = 0;
                List<T> result = new List<T>();
                while (rightIndex + leftIndex <= (left.Count + right.Count) - 1)
                {
                    if (leftIndex >= left.Count)
                    {
                        result.Add(right[rightIndex++]);
                    }
                    else if(rightIndex >= right.Count)
                    {
                        result.Add(left[leftIndex++]);
                    }
                    else if (left[leftIndex].CompareTo(right[rightIndex]) > 0)
                    {
                        result.Add(right[rightIndex++]);
                    }
                    else
                    {
                        result.Add(left[leftIndex++]);
                    }
                }
                return result.ToArray();
            }
            else
            {
                return items;
            }

        }

        public static IList<T> QuickSort<T>(IList<T> items) where T : IComparable<T>
        {
            if(items.Count <= 1)
            {
                return items;
            }
            Random random = new Random();
            int randomIndex = random.Next(0, items.Count);
            T pivot = items[randomIndex];
            IList<T> left = items.Where(item => item.CompareTo(pivot) < 0).ToList();
            IList<T> right = items.Where(item => item.CompareTo(pivot) >= 0).ToList();
            return QuickSort(left).Concat(QuickSort(right)).ToArray();
        }
    }
}
