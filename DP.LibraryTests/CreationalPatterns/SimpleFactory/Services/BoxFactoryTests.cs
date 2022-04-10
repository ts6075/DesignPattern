using DP.Library.CreationalPatterns.SimpleFactory.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DP.Library.CreationalPatterns.SimpleFactory.Services.Tests
{
    [TestClass()]
    public class BoxFactoryTests
    {
        /// <summary>
        /// 正向測試
        /// </summary>
        /// <param name="boxType">盒子種類</param>
        [DataRow(BoxType.Circle)]
        [DataRow(BoxType.Square)]
        [DataRow(BoxType.Rectangle)]
        [DataRow(BoxType.Triangle)]
        [DataRow(BoxType.Pentagon)]
        [TestMethod()]
        public void CreateBox_PositiveTest(BoxType boxType)
        {
            var factory = new BoxFactory();
            var box = factory.CreateBox(boxType);
            var shape = box.GetBoxShape();

            Assert.AreEqual(boxType.ToString(), shape);
        }

        /// <summary>
        /// 反向測試
        /// </summary>
        [TestMethod()]
        public void CreateBox_NegativeTesting()
        {
            var factory = new BoxFactory();

            Assert.ThrowsException<NotImplementedException>(() =>
            {
                var box = factory.CreateBox((BoxType)999);
            });
        }
    }
}