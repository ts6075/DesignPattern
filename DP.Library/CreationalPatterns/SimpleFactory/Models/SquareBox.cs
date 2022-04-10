using DP.Library.CreationalPatterns.SimpleFactory.Enum;
using DP.Library.CreationalPatterns.SimpleFactory.Models.Interface;

namespace DP.Library.CreationalPatterns.SimpleFactory.Models
{
    /// <summary>
    /// 正方形盒子
    /// </summary>
    public class SquareBox : IBox
    {
        /// <summary>
        /// 取得盒子形狀
        /// </summary>
        public string GetBoxShape()
            => BoxType.Square.ToString();
    }
}