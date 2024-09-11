using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaFigure.UnitTestFigure
{
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void GetStringTests_NullReturned()
        {
            //Arrange
            var figure = new AngularFigure(1, 1);
            //Act
            string result = figure.ToString();
            //Assert
            Assert.AreEqual(figure.ToString(), result);
        }
    }

    [TestClass]
    public class AngularFigureTests
    {
        [TestMethod]
        public void IsStraightTriangle_5and5and3_true_Returned()
        {
            //Arrange
            var triangle = new AngularFigure("Triangle", 5, 5, 3);
            //Act
            var result = triangle.IsStraightTriangle();
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GetAreaTriangle_5and9and13_16_Returned()
        {
            //Arrange
            var triangle = new AngularFigure("Треугольник", 5, 9, 13);
            int expected = 16;

            //Act
            var result = triangle.GetArea();

            //Assert
            Assert.AreEqual(expected, (int)result);
        }

        [TestMethod]
        public void GetAreaSquare_3_9_Returned()
        {
            //Arrange
            var square = new AngularFigure("Квадрат", 3);
            double expected = 9;

            //Act
            var result = square.GetArea();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetAreaRectangle_5and9_45_Returned()
        {
            //Arrange
            var triangle = new AngularFigure("Прямоугольник", 5, 9);
            int expected = 45;

            //Act
            var result = triangle.GetArea();

            //Assert
            Assert.AreEqual(expected, (int)result);
        }

        [TestMethod]
        public void GetAreaWithoutName_3_9_Returned()
        {
            //Arrange
            var square = new AngularFigure(3);
            double expected = 9;

            //Act
            var result = square.GetArea();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }

    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetAreaCircle_4_50_2f_Returned()
        {
            //Arrange
            var circle = new Circle("Круг", 4f);
            float expected = 50.2f;

            //Act
            var result = circle.GetArea();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
