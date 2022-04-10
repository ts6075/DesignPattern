﻿using DP.Library.CreationalPatterns.FactoryMethod.Enum;
using DP.Library.CreationalPatterns.FactoryMethod.Models.Interface;

namespace DP.Library.CreationalPatterns.FactoryMethod.Models
{
    /// <summary>
    /// 五角形盒子
    /// </summary>
    public class PentagonBox : IBox
    {
        /// <summary>
        /// 取得盒子形狀
        /// </summary>
        public string GetBoxShape()
            => BoxType.Pentagon.ToString();
    }
}