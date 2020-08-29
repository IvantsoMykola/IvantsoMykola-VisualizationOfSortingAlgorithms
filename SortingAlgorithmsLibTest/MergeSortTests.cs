using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingAlgorithmsLibTests
{
    [TestClass]
    public class MergeSortTests
    {
        #region int

        [TestMethod]
        public void MergeSort_IntIListSorted_SortedItemsReturned()
        {
            // Arrange
            int[] actualItems = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] expectedItems = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.MergeSort(actualItems) as int[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void MergeSort_IntIListOneSwap_SortedItemsReturned()
        {
            // Arrange
            int[] actualItems = new int[] { 1, 6, 3, 4, 5, 2, 7 };
            int[] expectedItems = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.MergeSort(actualItems) as int[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void MergeSort_RandomIntIList_SortedItemsReturned()
        {
            // Arrange
            int[] actualItems = new int[] { 3, 6, 7, 1, 5, 2, 4, 8 };
            int[] expectedItems = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.MergeSort(actualItems) as int[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void MergeSort_EmptyIntIList_SortedItemsReturned()
        {
            // Arrange
            int[] actualItems = new int[] { };
            int[] expectedItems = new int[] { };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.MergeSort(actualItems) as int[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void MergeSort_IntIListWithTwoItems_SortedItemsReturned()
        {
            // Arrange
            int[] actualItems = new int[] { 2, 1 };
            int[] expectedItems = new int[] { 1, 2 };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.MergeSort(actualItems) as int[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }

        #endregion

        //TODO Add double
    }
}
