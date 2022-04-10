using DP.Library.CreationalPatterns.FactoryMethod.Enum;
using DP.Library.CreationalPatterns.FactoryMethod.Models.Interface;
using DP.Library.CreationalPatterns.FactoryMethod.Services;
using DP.Library.CreationalPatterns.FactoryMethod.Services.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DP.Library.CreationalPatterns.FactoryMethod.Tests
{
    [TestClass()]
    public class FactoryMethodTests
    {
        /// <summary>
        /// 正向測試
        /// </summary>
        [TestMethod()]
        public void CreateCircleBox_PositiveTest()
        {
            var factory = new CircleBoxFactory();
            var box = factory.CreateBox();
            var shape = box.GetBoxShape();

            Assert.IsInstanceOfType(factory, typeof(IBoxFactory));
            Assert.IsInstanceOfType(box, typeof(IBox));
            Assert.AreEqual(BoxType.Circle.ToString(), shape);
        }

        /// <summary>
        /// 正向測試
        /// </summary>
        [TestMethod()]
        public void CreateSquareBox_PositiveTest()
        {
            var factory = new SquareBoxFactory();
            var box = factory.CreateBox();
            var shape = box.GetBoxShape();

            Assert.IsInstanceOfType(factory, typeof(IBoxFactory));
            Assert.IsInstanceOfType(box, typeof(IBox));
            Assert.AreEqual(BoxType.Square.ToString(), shape);
        }

        /// <summary>
        /// 正向測試
        /// </summary>
        [TestMethod()]
        public void CreateRectangleBox_PositiveTest()
        {
            var factory = new RectangleBoxFactory();
            var box = factory.CreateBox();
            var shape = box.GetBoxShape();

            Assert.IsInstanceOfType(factory, typeof(IBoxFactory));
            Assert.IsInstanceOfType(box, typeof(IBox));
            Assert.AreEqual(BoxType.Rectangle.ToString(), shape);
        }

        /// <summary>
        /// 正向測試
        /// </summary>
        [TestMethod()]
        public void CreateTriangleBox_PositiveTest()
        {
            var factory = new TriangleBoxFactory();
            var box = factory.CreateBox();
            var shape = box.GetBoxShape();

            Assert.IsInstanceOfType(factory, typeof(IBoxFactory));
            Assert.IsInstanceOfType(box, typeof(IBox));
            Assert.AreEqual(BoxType.Triangle.ToString(), shape);
        }

        /// <summary>
        /// 正向測試
        /// </summary>
        [TestMethod()]
        public void CreatePentagonBox_PositiveTest()
        {
            var factory = new PentagonBoxFactory();
            var box = factory.CreateBox();
            var shape = box.GetBoxShape();

            Assert.IsInstanceOfType(factory, typeof(IBoxFactory));
            Assert.IsInstanceOfType(box, typeof(IBox));
            Assert.AreEqual(BoxType.Pentagon.ToString(), shape);
        }
    }
}