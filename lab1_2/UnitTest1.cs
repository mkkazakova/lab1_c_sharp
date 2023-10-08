namespace lab1_2Tests
{   
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void TestRectangleArea()
        {
            // arrange
            double side1 = 0;
            double side2 = 4;
            double side3 = 5;
            Rectangle rect1 = new Rectangle(side1, side2);
            Rectangle rect2 = new Rectangle(side2, side3);
            double expectedArea1 = side1 * side2;
            double expectedArea2 = side2 * side3;

            // act
            double actualArea1 = rect1.Area;
            double actualArea2 = rect2.Area;


            // assert
            Assert.AreEqual(expectedArea1, actualArea1, 0.1, "OMG1");
            Assert.AreEqual(expectedArea2, actualArea2, 0.1, "OMG2");
        }

        [TestMethod]
        public void TestRectanglePerimeter()
        {
            // arrange
            double side1 = 5;
            double side2 = 10;
            Rectangle rect = new Rectangle(side1, side2);
            double expectedPerimeter = 2 * (side1 + side2);

            // act
            double actualPerimeter = rect.Perimeter;

            // assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
    }
    
}