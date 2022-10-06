namespace TestClassLibrary03
{
    using ClassLibrary03;

    [TestClass]
    public class TestCar
    {
        [TestMethod]
        public void test_car1_equals_car2_true()
        {
            // Arrange
            Car car1 = new("BMV", "A", 200);
            Car car2 = new("BMV", "A", 200);

            // Assert
            Assert.IsTrue(car1.Equals(car2));
        }

        [TestMethod]
        public void test_car1_equals_car2_false()
        {
            // Arrange
            Car car1 = new("BMV", "A", 200);
            Car car2 = new("Mersedez", "B", 180);

            // Assert
            Assert.IsFalse(car1.Equals(car2));
        }
    }
}
