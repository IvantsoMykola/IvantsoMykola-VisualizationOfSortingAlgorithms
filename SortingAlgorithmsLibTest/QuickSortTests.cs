using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Resources;
using System.Threading;

namespace SortingAlgorithmsLibTests
{
    [TestClass]
    public class QuickSortTests
    {
        #region int

        [TestMethod]
        public void QuickSort_IntIListSorted_SortedItemsReturned()
        {
            // Arrange
            int[] actualItems = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] expectedItems = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.QuickSort(actualItems) as int[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void QuickSort_IntIListOneSwap_SortedItemsReturned()
        {
            // Arrange
            int[] actualItems = new int[] { 1, 6, 3, 4, 5, 2, 7 };
            int[] expectedItems = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.QuickSort(actualItems) as int[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void QuickSort_RandomIntIList_SortedItemsReturned()
        {
            // Arrange
            int[] actualItems = new int[] { 3, 6, 7, 1, 5, 2, 4, 8 };
            int[] expectedItems = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.QuickSort(actualItems) as int[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void QuickSort_EmptyIntIList_SortedItemsReturned()
        {
            // Arrange
            int[] actualItems = new int[] { };
            int[] expectedItems = new int[] { };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.QuickSort(actualItems) as int[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void QuickSort_IntIListWithTwoItems_SortedItemsReturned()
        {
            // Arrange
            int[] actualItems = new int[] { 2, 1 };
            int[] expectedItems = new int[] { 1, 2 };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.QuickSort(actualItems) as int[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }

        #endregion

        #region double

        [TestMethod]
        public void QuickSort_DoubleIListSorted_SortedItemsReturned()
        {
            // Arrange
            double[] actualItems = new double[] { 4.96, 13.15, 13.41, 15.37, 30.54, 35.53, 64.09, 67.26, 72.41, 86.59 };
            double[] expectedItems = new double[] { 4.96, 13.15, 13.41, 15.37, 30.54, 35.53, 64.09, 67.26, 72.41, 86.59 };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.QuickSort(actualItems) as double[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void QuickSort_DoubleIListOneSwap_SortedItemsReturned()
        {
            // Arrange
            double[] actualItems = new double[] { 4.96, 13.15, 67.26, 15.37, 30.54, 35.53, 64.09, 13.41, 72.41, 86.59 };
            double[] expectedItems = new double[] { 4.96, 13.15, 13.41, 15.37, 30.54, 35.53, 64.09, 67.26, 72.41, 86.59 };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.QuickSort(actualItems) as double[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void QuickSort_DoubleRandomIList_SortedItemsReturned()
        {
            // Arrange
            double[] actualItems = new double[] { 64.09, 4.96, 13.15, 13.41, 67.26, 86.59, 72.41, 15.37, 30.54, 35.53 };
            double[] expectedItems = new double[] { 4.96, 13.15, 13.41, 15.37, 30.54, 35.53, 64.09, 67.26, 72.41, 86.59 };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.QuickSort(actualItems) as double[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void QuickSort_EmptyDoubleIList_SortedItemsReturned()
        {
            // Arrange
            double[] actualItems = new double[] { };
            double[] expectedItems = new double[] { };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.QuickSort(actualItems) as double[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void QuickSort_DoubleIListWithTwoItems_SortedItemsReturned()
        {
            // Arrange
            double[] actualItems = new double[] { 13.15, 4.96 };
            double[] expectedItems = new double[] { 4.96, 13.15 };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.QuickSort(actualItems) as double[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }

        #endregion

        #region BigDataTests

        

        [TestMethod]
        public void QuickSort_Sort1000000IntItems_SortedItemsReturned()
        {
            // Arrange
            ResourceManager resourceManager = SortingAlgorithmsLibTests.IntegerData.ResourceManager;
            var actualString = resourceManager.GetString("UnsortedInteger");
            var expectedString = resourceManager.GetString("SortedInteger");
            var actualStringList = actualString.Split("\r\n");
            var expectedStringList = expectedString.Split("\r\n");
            actualStringList = actualStringList.Where(item => int.TryParse(item, out _)).ToArray();
            expectedStringList = expectedStringList.Where(item => int.TryParse(item, out _)).ToArray();
            var actualValue = actualStringList.ToList().Select(item => int.Parse(item)).ToArray();
            var expectedValue = expectedStringList.ToList().Select(item => int.Parse(item)).ToArray();

            
            // Act
            actualValue = SortingAlgorithms.SortingAlgorithms.QuickSort(actualValue) as int[];
            
            // Assert

            CollectionAssert.AreEqual(expectedValue, actualValue);

        }

        #endregion

    }
}
