using DP.Library.CreationalPatterns.FactoryMethod.Enum;
using DP.Library.CreationalPatterns.FactoryMethod.Models.Interface;

namespace DP.Library.CreationalPatterns.FactoryMethod.Models
{
    /// <summary>
    /// 長方形盒子
    /// </summary>
    public class RectangleBox : IBox
    {
        /// <summary>
        /// 取得盒子形狀
        /// </summary>
        public string GetBoxShape()
            => BoxType.Rectangle.ToString();
    }
}