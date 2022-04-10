using DP.Library.CreationalPatterns.FactoryMethod.Enum;
using DP.Library.CreationalPatterns.FactoryMethod.Models.Interface;

namespace DP.Library.CreationalPatterns.FactoryMethod.Models
{
    /// <summary>
    /// 圓形盒子
    /// </summary>
    public class CircleBox : IBox
    {
        /// <summary>
        /// 取得盒子形狀
        /// </summary>
        public string GetBoxShape()
            => BoxType.Circle.ToString();
    }
}