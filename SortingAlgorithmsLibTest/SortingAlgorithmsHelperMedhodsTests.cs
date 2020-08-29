using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingAlgorithmsLibTests
{
    [TestClass]
    public class SortingAlgorithmsHelperMedhodsTests
    {
        #region SwapTests

        [TestMethod]
        public void Swap_2Swap5_SwappedReturned()
        {
            // Arrange
            double[] actualItems = new double[] { 1, 2, 3, 4, 5, 6, 7};
            double[] expectedItems = new double[] { 1, 2, 6, 4, 5, 3, 7 };
            int leftIndex = 2;
            int rightIndex = 5;

            // Act
            SortingAlgorithms.SortingAlgorithms.Swap<double>(actualItems, leftIndex, rightIndex);

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void Swap_0Swap5_SwappedReturned()
        {
            // Arrange
            double[] actualItems = new double[] { 1, 2, 3, 4, 5, 6, 7 };
            double[] expectedItems = new double[] { 6, 2, 3, 4, 5, 1, 7 };
            int leftIndex = 0;
            int rightIndex = 5;

            // Act
            SortingAlgorithms.SortingAlgorithms.Swap<double>(actualItems, leftIndex, rightIndex);

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void Swap_0Swap0_SwappedReturned()
        {
            // Arrange
            double[] actualItems = new double[] { 1, 2, 3, 4, 5, 6, 7 };
            double[] expectedItems = new double[] { 1, 2, 3, 4, 5, 6, 7 };
            int leftIndex = 0;
            int rightIndex = 0;

            // Act
            SortingAlgorithms.SortingAlgorithms.Swap<double>(actualItems, leftIndex, rightIndex);

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void Swap_0Swap1_SwappedReturned()
        {
            // Arrange
            double[] actualItems = new double[] { 1, 2, 3, 4, 5, 6, 7 };
            double[] expectedItems = new double[] { 2, 1, 3, 4, 5, 6, 7 };
            int leftIndex = 0;
            int rightIndex = 1;

            // Act
            SortingAlgorithms.SortingAlgorithms.Swap<double>(actualItems, leftIndex, rightIndex);

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }
        [TestMethod]
        public void Swap_5Swap6_SwappedReturned()
        {
            // Arrange
            double[] actualItems = new double[] { 1, 2, 3, 4, 5, 6, 7 };
            double[] expectedItems = new double[] { 1, 2, 3, 4, 5, 7, 6 };
            int leftIndex = 5;
            int rightIndex = 6;

            // Act
            SortingAlgorithms.SortingAlgorithms.Swap<double>(actualItems, leftIndex, rightIndex);

            // Assert
            CollectionAssert.AreEqual(expectedItems, actualItems);
        }

        #endregion
        
        #region FindIndexOfSmallest

        [TestMethod]
        public void FindIndexOfSmallest_FindIndexOf1_SortedItemsReturned()
        {
            // Arrange
            int[] items = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int expectedValue = 0;

            // Act
            int actualValue = SortingAlgorithms.SortingAlgorithms.FindIndexOfSmallest(items);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void FindIndexOfSmallest_FindIndexOf3_4Returned()
        {
            // Arrange
            int[] items = new int[] { 123, 124, 124, 6, 3, 4, 5, 23, 12, 6345, 34, 7 };
            int expectedValue = 4;
            // Act
            int actualValue = SortingAlgorithms.SortingAlgorithms.FindIndexOfSmallest(items);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void FindIndexOfSmallest_EmptyIntIList_ArgumentExceptionReturned()
        {
            // Arrange
            int[] items = new int[] { };
            

            // Act
            SortingAlgorithms.SortingAlgorithms.FindIndexOfSmallest(items);

            // Assert
        }
        [TestMethod]
        public void FindIndexOfSmallest_IntIListWithTwoItems_SortedItemsReturned()
        {
            // Arrange
            int[] items = new int[] { 2, 1 };
            int expectedValue = 1;

            // Act
            int actualValue = SortingAlgorithms.SortingAlgorithms.FindIndexOfSmallest(items);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        #endregion

    }
}
