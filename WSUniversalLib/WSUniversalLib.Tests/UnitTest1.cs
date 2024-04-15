using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;

namespace WSUniversalTests
{
    [TestClass]
    public class MSUnivLibTests
    {
        private MSUnivLib msUnivLib = new MSUnivLib();

        [TestMethod]
        public void GetProductQuantity_InvalidProductType_ReturnsMinusOne()
        {
            // Arrange
            int productType = -1;
            double width = 1;
            double length = 1;
            int count = 1;
            int materialType = 1;

            // Act
            int result = msUnivLib.CalculateMaterialQuantity(productType, width, length, count, materialType);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void GetProductQuantity_InvalidMaterialType_ReturnsMinusOne()
        {
            // Arrange
            int productType = 1;
            double width = 1;
            double length = 1;
            int count = 1;
            int materialType = -1;

            // Act
            int result = msUnivLib.CalculateMaterialQuantity(productType, width, length, count, materialType);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void GetProductQuantity_InvalidCount_ReturnsMinusOne()
        {
            // Arrange
            int productType = 1;
            double width = 1;
            double length = 1;
            int count = -1;
            int materialType = 1;

            // Act
            int result = msUnivLib.CalculateMaterialQuantity(productType, width, length, count, materialType);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void GetProductQuantity_InvalidWidth_ReturnsMinusOne()
        {
            // Arrange
            int productType = 1;
            double width = -1;
            double length = 1;
            int count = 1;
            int materialType = 1;

            // Act
            int result = msUnivLib.CalculateMaterialQuantity(productType, width, length, count, materialType);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void GetProductQuantity_InvalidLength_ReturnsMinusOne()
        {
            // Arrange
            int productType = 1;
            double width = 1;
            double length = -1;
            int count = 1;
            int materialType = 1;

            // Act
            int result = msUnivLib.CalculateMaterialQuantity(productType, width, length, count, materialType);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CalculateMaterialQuantity_ValidData_ReturnsCorrectQuantity()
        {
            // Arrange
            int productType = 1;
            double width = 10;
            double length = 20;
            int count = 5;
            int materialType = 1;

            // Act
            int result = msUnivLib.CalculateMaterialQuantity(productType, width, length, count, materialType);

            // Assert
            Assert.AreEqual(1100, result);
        }

        [TestMethod]
        public void CalculateMaterialQuantity_InvalidProductTypeZero_ReturnsMinusOne()
        {
            // Arrange
            int productType = 0;
            double width = 10;
            double length = 20;
            int count = 5;
            int materialType = 1;

            // Act
            int result = msUnivLib.CalculateMaterialQuantity(productType, width, length, count, materialType);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CalculateMaterialQuantity_InvalidMaterialTypeZero_ReturnsMinusOne()
        {
            // Arrange
            int productType = 1;
            double width = 10;
            double length = 20;
            int count = 5;
            int materialType = 0;

            // Act
            int result = msUnivLib.CalculateMaterialQuantity(productType, width, length, count, materialType);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CalculateMaterialQuantity_InvalidWidthZero_ReturnsMinusOne()
        {
            // Arrange
            int productType = 1;
            double width = 0;
            double length = 20;
            int count = 5;
            int materialType = 1;

            // Act
            int result = msUnivLib.CalculateMaterialQuantity(productType, width, length, count, materialType);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CalculateMaterialQuantity_InvalidLengthZero_ReturnsMinusOne()
        {
            // Arrange
            int productType = 1;
            double width = 10;
            double length = 0;
            int count = 5;
            int materialType = 1;

            // Act
            int result = msUnivLib.CalculateMaterialQuantity(productType, width, length, count, materialType);

            // Assert
            Assert.AreEqual(-1, result);
        }


        [TestMethod]
        public void CalculateMaterialQuantity_ValidDoubleWidth_ReturnsCorrectQuantity()
        {
            // Arrange
            int productType = 2;
            double width = 23.42;
            double length = 55;
            int count = 12;
            int materialType = 1;

            // Act
            int result = msUnivLib.CalculateMaterialQuantity(productType, width, length, count, materialType);

            // Assert
            Assert.AreEqual(38690, result);
        }

        [TestMethod]
        public void CalculateMaterialQuantity_ValidDoubleLength_ReturnsCorrectQuantity()
        {
            // Arrange
            int productType = 1;
            double width = 234;
            double length = 55;
            int count = 23;
            int materialType = 2;

            // Act
            int result = msUnivLib.CalculateMaterialQuantity(productType, width, length, count, materialType);

            // Assert
            Assert.AreEqual(331956, result);
        }

        [TestMethod]
        public void CalculateMaterialQuantity_ValidDoubleWidthLength_ReturnsCorrectQuantity()
        {
            // Arrange
            int productType = 3;
            double width = 1532.324;
            double length = 142.123;
            int count = 55;
            int materialType = 1;

            // Act
            int result = msUnivLib.CalculateMaterialQuantity(productType, width, length, count, materialType);

            // Assert
            Assert.AreEqual(101276825, result);
        }

        [TestMethod]
        public void CalculateMaterialQuantity_ValidBigValues_ReturnsCorrectQuantity()
        {
            // Arrange
            int productType = 1;
            double width = 53231;
            double length = 323;
            int count = 3;
            int materialType = 2;

            // Act
            int result = msUnivLib.CalculateMaterialQuantity(productType, width, length, count, materialType);

            // Assert
            Assert.AreEqual(56909652, result);
        }
    }
}
