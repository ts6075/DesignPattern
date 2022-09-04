using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DP.Library.BehaviouralPatterns.Observer.Services.Tests
{
    [TestClass()]
    public class ObserverTests
    {
        /// <summary>
        /// 正向測試
        /// </summary>
        [TestMethod()]
        public void MainTest_PositiveTest()
        {
            Observer observer = new();
            observer.Main();
        }
    }
}