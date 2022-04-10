﻿using DP.Library.CreationalPatterns.FactoryMethod.Models;
using DP.Library.CreationalPatterns.FactoryMethod.Models.Interface;
using DP.Library.CreationalPatterns.FactoryMethod.Services.Interface;

namespace DP.Library.CreationalPatterns.FactoryMethod.Services
{
    /// <summary>
    /// 長方形盒子工廠
    /// </summary>
    public class RectangleBoxFactory : IBoxFactory
    {
        /// <summary>
        /// 建立盒子
        /// </summary>
        public IBox CreateBox()
            => new RectangleBox();
    }
}
