using DP.Library.CreationalPatterns.SimpleFactory.Enum;
using DP.Library.CreationalPatterns.SimpleFactory.Models;
using DP.Library.CreationalPatterns.SimpleFactory.Models.Interface;

namespace DP.Library.CreationalPatterns.SimpleFactory.Services
{
    /// <summary>
    /// 盒子工廠
    /// </summary>
    public class BoxFactory
    {
        /// <summary>
        /// 建立盒子
        /// </summary>
        /// <param name="boxType">盒子種類</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IBox CreateBox(BoxType boxType)
        {
            IBox box = boxType switch
            {
                BoxType.Circle => new CircleBox(),
                BoxType.Square => new SquareBox(),
                BoxType.Triangle => new TriangleBox(),
                BoxType.Rectangle => new RectangleBox(),
                BoxType.Pentagon => new PentagonBox(),
                _ => throw new NotImplementedException()
            };
            return box;
        }
    }
}
