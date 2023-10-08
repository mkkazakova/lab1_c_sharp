using System.Drawing;

namespace lab1_3Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLengthSide()
        {
            Point A = new Point(0, 0);
            Point B = new Point(0, 3);
            Point C = new Point(1, 1);
            Figure fig0 = new(A, B, C, Figure.FigureType.Triangle);

            double length1 = fig0.LengthSide(A, B);
            double length2 = fig0.LengthSide(B, C);

            Assert.AreEqual(3.0, length1, 0.001);
            Assert.AreEqual(2.236, length2, 0.001);
        }

        [TestMethod]
        public void TrianglePerimeter()
        {
            Point p1 = new(0, 0);
            Point p2 = new(0, 3);
            Point p3 = new(4, 0);
            Figure fig1 = new(p1, p2, p3, Figure.FigureType.Triangle);
            Assert.AreEqual(12.0, fig1.PerimeterCalculator(), 0.001);
        }

        [TestMethod]
        public void QuadranglePerimeter()
        {
            Point p4 = new Point(0, 0);
            Point p5 = new Point(0, 5);
            Point p6 = new Point(5, 5);
            Point p7 = new Point(5, 0);
            Figure fig2 = new Figure(p4, p5, p6, p7, Figure.FigureType.Square);
            
            Assert.AreEqual(20.0, fig2.PerimeterCalculator(), 0.001);
        }

        [TestMethod]
        public void PentagonPerimeter()
        {
            Point p8 = new(0, 0);
            Point p9 = new(3, 0);
            Point p10 = new(7, 3);
            Point p11 = new(3, 6);
            Point p12 = new(0, 2);
            Figure fig3 = new(p8, p9, p10, p11, p12, Figure.FigureType.Pentagon);
            
            Assert.AreEqual(20.0, fig3.PerimeterCalculator(), 0.001);
        }
    }
}