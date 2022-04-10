using DP.Library.CreationalPatterns.FactoryMethod.Models.Interface;

namespace DP.Library.CreationalPatterns.FactoryMethod.Services.Interface
{
    /// <summary>
    /// 盒子工廠
    /// </summary>
    public interface IBoxFactory
    {
        /// <summary>
        /// 建立盒子
        /// </summary>
        public IBox CreateBox();
    }
}
