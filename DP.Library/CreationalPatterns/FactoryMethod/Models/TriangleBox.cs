using DP.Library.CreationalPatterns.FactoryMethod.Enum;
using DP.Library.CreationalPatterns.FactoryMethod.Models.Interface;

namespace DP.Library.CreationalPatterns.FactoryMethod.Models
{
    /// <summary>
    /// 三角形盒子
    /// </summary>
    public class TriangleBox : IBox
    {
        /// <summary>
        /// 取得盒子形狀
        /// </summary>
        public string GetBoxShape()
            => BoxType.Triangle.ToString();
    }
}