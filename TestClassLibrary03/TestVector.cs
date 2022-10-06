namespace TestClassLibrary03
{
    using ClassLibrary03;

    [TestClass]
    public class TestVectorActOperators
    {
        [TestMethod]
        public void Test_Vector_2_3_4_plus_Vector_1_1_2_is_3_4_6()
        {
            // Arrange
            Vector a = new(2, 3, 4);
            Vector b = new(1, 1, 2);

            Vector ExpectedVector = new(3, 4, 6);

            // Act
            Vector ActualVector = a + b;

            // Assert
            Assert.AreEqual(ExpectedVector, ActualVector);

        }

        [TestMethod]
        public void Test_Vector_1_2_1_mult_Vector_2_1_1_is_5()
        {
            // Arrange
            Vector a = new(1, 2, 1);
            Vector b = new(2, 1, 1);

            double ExpectedResult = 5;

            // Act
            var ActualResult = a * b;

            // Assert
            Assert.AreEqual(ExpectedResult, ActualResult);

        }

        [TestMethod]
        public void Test_Vector_1_2_3_mult_3_is_3_6_9()
        {
            // Arrange
            Vector a = new(1, 2, 3);

            Vector ExpectedVector = new(3, 6, 9);

            // Act
            Vector ActualVector = a * 3;

            // Assert
            Assert.AreEqual(ExpectedVector, ActualVector);

        }

        [TestMethod]
        public void Test_3_mult_Vector_1_2_3_is_3_6_9()
        {
            // Arrange
            Vector a = new(1, 2, 3);

            Vector ExpectedVector = new(3, 6, 9);

            // Act
            Vector ActualVector = 3 * a;

            // Assert
            Assert.AreEqual(ExpectedVector, ActualVector);

        }
    }

    [TestClass]
    public class TestVectorCompareOperators
    {

        [TestMethod]
        public void Test_Vector_2_1_2_length_is_equal_Vector_0_0_3()
        {
            // Arrange
            Vector a = new(2, 1, 2);
            Vector b = new(0, 0, 3);

            // Assert
            Assert.IsTrue(a == b);
        }

        [TestMethod]
        public void Test_Vector_2_1_0_length_is_not_equal_Vector_2_1_1()
        {
            // Arrange
            Vector a = new(2, 1, 0);
            Vector b = new(2, 1, 1);

            // Assert
            Assert.IsTrue(a != b);
        }

        [TestMethod]
        public void Test_Vector_2_1_2_are_not_equal_Vector_0_0_3()
        {
            // Arrange
            Vector a = new(2, 1, 2);
            Vector b = new(0, 0, 3);

            // Assert
            Assert.AreNotEqual(a, b);
        }

        [TestMethod]
        public void Test_Vector_5_0_0_is_longer_or_equal_Vector_4_0_3()
        {
            // Arrange
            Vector a = new(5, 0, 0);
            Vector b = new(4, 0, 3);

            // Assert
            Assert.IsTrue(a >= b);
            Assert.IsFalse(a > b);
        }

        public void Test_Vector_2_3_3_is_less_or_equal_Vector_5_0_0()
        {
            // Arrange
            Vector a = new(2, 3, 3);
            Vector b = new(5, 0, 0);

            // Assert
            Assert.IsTrue(a <= b);
            Assert.IsTrue(a < b);
        }
    }
}