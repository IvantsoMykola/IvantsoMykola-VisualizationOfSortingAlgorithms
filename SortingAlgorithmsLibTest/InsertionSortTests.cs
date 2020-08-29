using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SortingAlgorithmsLibTests
{
    [TestClass]
    public class InsertionSortTests
    {
        #region int

        [TestMethod]
        public void InsertionSort_IntIListSorted_SortedItemsReturned()
        {
            // Arrange
            int[] actualItems = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] expectedItems = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            // Act
            SortingAlgorithms.SortingAlgorithms.InsertionSort(actualItems);

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void InsertionSort_IntIListOneSwap_SortedItemsReturned()
        {
            // Arrange
            int[] actualItems = new int[] { 1, 6, 3, 4, 5, 2, 7 };
            int[] expectedItems = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            // Act
            SortingAlgorithms.SortingAlgorithms.InsertionSort(actualItems);

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void InsertionSort_RandomIntIList_SortedItemsReturned()
        {
            // Arrange
            int[] actualItems = new int[] { 3, 6, 7, 1, 5, 2, 4 };
            int[] expectedItems = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            // Act
            SortingAlgorithms.SortingAlgorithms.InsertionSort(actualItems);

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void InsertionSort_EmptyIntIList_SortedItemsReturned()
        {
            // Arrange
            int[] actualItems = new int[] { };
            int[] expectedItems = new int[] { };

            // Act
            SortingAlgorithms.SortingAlgorithms.InsertionSort(actualItems);

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void InsertionSort_IntIListWithTwoItems_SortedItemsReturned()
        {
            // Arrange
            int[] actualItems = new int[] { 2, 1 };
            int[] expectedItems = new int[] { 1, 2 };

            // Act
            SortingAlgorithms.SortingAlgorithms.InsertionSort(actualItems);

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }

        #endregion

        //TODO Add double
    }
}
