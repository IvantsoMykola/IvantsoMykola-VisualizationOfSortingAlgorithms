using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Resources;

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

        #region double

        [TestMethod]
        public void MergeSort_DoubleIListSorted_SortedItemsReturned()
        {
            // Arrange
            double[] actualItems = new double[] { 4.96, 13.15, 13.41, 15.37, 30.54, 35.53, 64.09, 67.26, 72.41, 86.59 };
            double[] expectedItems = new double[] { 4.96, 13.15, 13.41, 15.37, 30.54, 35.53, 64.09, 67.26, 72.41, 86.59 };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.MergeSort(actualItems) as double[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void MergeSort_DoubleIListOneSwap_SortedItemsReturned()
        {
            // Arrange
            double[] actualItems = new double[] { 4.96, 13.15, 67.26, 15.37, 30.54, 35.53, 64.09, 13.41, 72.41, 86.59 };
            double[] expectedItems = new double[] { 4.96, 13.15, 13.41, 15.37, 30.54, 35.53, 64.09, 67.26, 72.41, 86.59 };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.MergeSort(actualItems) as double[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void MergeSort_DoubleRandomIList_SortedItemsReturned()
        {
            // Arrange
            double[] actualItems = new double[] { 64.09, 4.96, 13.15, 13.41, 67.26, 86.59, 72.41, 15.37, 30.54, 35.53 };
            double[] expectedItems = new double[] { 4.96, 13.15, 13.41, 15.37, 30.54, 35.53, 64.09, 67.26, 72.41, 86.59 };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.MergeSort(actualItems) as double[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void MergeSort_EmptyDoubleIList_SortedItemsReturned()
        {
            // Arrange
            double[] actualItems = new double[] { };
            double[] expectedItems = new double[] { };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.MergeSort(actualItems) as double[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void MergeSort_DoubleIListWithTwoItems_SortedItemsReturned()
        {
            // Arrange
            double[] actualItems = new double[] { 13.15, 4.96 };
            double[] expectedItems = new double[] { 4.96, 13.15 };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.MergeSort(actualItems) as double[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }

        #endregion

        #region DateTime

        [TestMethod]
        public void MergeSort_DateTimeIListSorted_SortedItemsReturned()
        {
            // Arrange
            //YYYY, M, D, H, M, S
            DateTime[] actualItems = new DateTime[] {
                new DateTime(2008, 5, 1, 8, 30, 52),
                new DateTime(2009, 5, 1, 8, 30, 52),
                new DateTime(2010, 5, 1, 8, 30, 52),
                new DateTime(2010, 6, 1, 8, 30, 52),
                new DateTime(2010, 7, 1, 8, 30, 52),
                new DateTime(2010, 8, 2, 8, 30, 52),
                new DateTime(2010, 8, 5, 8, 30, 52),
                new DateTime(2010, 8, 5, 10, 30, 52),
                new DateTime(2010, 8, 5, 10, 38, 52)
            };
            DateTime[] expectedItems = new DateTime[] {
                new DateTime(2008, 5, 1, 8, 30, 52),
                new DateTime(2009, 5, 1, 8, 30, 52),
                new DateTime(2010, 5, 1, 8, 30, 52),
                new DateTime(2010, 6, 1, 8, 30, 52),
                new DateTime(2010, 7, 1, 8, 30, 52),
                new DateTime(2010, 8, 2, 8, 30, 52),
                new DateTime(2010, 8, 5, 8, 30, 52),
                new DateTime(2010, 8, 5, 10, 30, 52),
                new DateTime(2010, 8, 5, 10, 38, 52)
            };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.MergeSort(actualItems) as DateTime[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void MergeSort_DateTimeIListOneSwap_SortedItemsReturned()
        {
            // Arrange
            //YYYY, M, D, H, M, S
            DateTime[] actualItems = new DateTime[] {
                new DateTime(2008, 5, 1, 8, 30, 52),
                new DateTime(2010, 5, 1, 8, 30, 52),
                new DateTime(2009, 5, 1, 8, 30, 52),
                new DateTime(2010, 6, 1, 8, 30, 52),
                new DateTime(2010, 7, 1, 8, 30, 52),
                new DateTime(2010, 8, 2, 8, 30, 52),
                new DateTime(2010, 8, 5, 8, 30, 52),
                new DateTime(2010, 8, 5, 10, 30, 52),
                new DateTime(2010, 8, 5, 10, 38, 52)
            };
            DateTime[] expectedItems = new DateTime[] {
                new DateTime(2008, 5, 1, 8, 30, 52),
                new DateTime(2009, 5, 1, 8, 30, 52),
                new DateTime(2010, 5, 1, 8, 30, 52),
                new DateTime(2010, 6, 1, 8, 30, 52),
                new DateTime(2010, 7, 1, 8, 30, 52),
                new DateTime(2010, 8, 2, 8, 30, 52),
                new DateTime(2010, 8, 5, 8, 30, 52),
                new DateTime(2010, 8, 5, 10, 30, 52),
                new DateTime(2010, 8, 5, 10, 38, 52)
            };
            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.MergeSort(actualItems) as DateTime[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void MergeSort_DateTimeRandomIList_SortedItemsReturned()
        {
            // Arrange
            //YYYY, M, D, H, M, S
            DateTime[] actualItems = new DateTime[] {
                new DateTime(2008, 5, 1, 8, 30, 52),
                new DateTime(2010, 5, 1, 8, 30, 52),
                new DateTime(2010, 6, 1, 8, 30, 52),
                new DateTime(2009, 5, 1, 8, 30, 52),
                new DateTime(2010, 7, 1, 8, 30, 52),
                new DateTime(2010, 8, 2, 8, 30, 52),
                new DateTime(2010, 8, 5, 8, 30, 52),
                new DateTime(2010, 8, 5, 10, 30, 52),
                new DateTime(2010, 8, 5, 10, 38, 52)
            };
            DateTime[] expectedItems = new DateTime[] {
                new DateTime(2008, 5, 1, 8, 30, 52),
                new DateTime(2009, 5, 1, 8, 30, 52),
                new DateTime(2010, 5, 1, 8, 30, 52),
                new DateTime(2010, 6, 1, 8, 30, 52),
                new DateTime(2010, 7, 1, 8, 30, 52),
                new DateTime(2010, 8, 2, 8, 30, 52),
                new DateTime(2010, 8, 5, 8, 30, 52),
                new DateTime(2010, 8, 5, 10, 30, 52),
                new DateTime(2010, 8, 5, 10, 38, 52)
            };
            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.MergeSort(actualItems) as DateTime[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void MergeSort_EmptyDateTimeIList_SortedItemsReturned()
        {
            // Arrange
            //YYYY, M, D, H, M, S
            DateTime[] actualItems = new DateTime[] { };
            DateTime[] expectedItems = new DateTime[] { };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.MergeSort(actualItems) as DateTime[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void MergeSort_DateTimeIListWithTwoItems_SortedItemsReturned()
        {
            // Arrange
            //YYYY, M, D, H, M, S
            DateTime[] actualItems = new DateTime[] { new DateTime(2010, 6, 1, 8, 30, 52), new DateTime(2010, 5, 1, 8, 30, 52) };
            DateTime[] expectedItems = new DateTime[] { new DateTime(2010, 5, 1, 8, 30, 52), new DateTime(2010, 6, 1, 8, 30, 52) };

            // Act
            actualItems = SortingAlgorithms.SortingAlgorithms.MergeSort(actualItems) as DateTime[];

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }

        #endregion

        #region BigDataTests

        [TestMethod]
        public void MergeSort_Sort1000000IntItems_SortedItemsReturned()
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
            actualValue = SortingAlgorithms.SortingAlgorithms.MergeSort(actualValue) as int[];

            // Assert
            CollectionAssert.AreEqual(expectedValue, actualValue);

        }

        #endregion
    }
}
