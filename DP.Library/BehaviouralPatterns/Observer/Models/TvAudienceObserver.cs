using DP.Library.BehaviouralPatterns.Observer.Models.Abstracts;

namespace DP.Library.BehaviouralPatterns.Observer.Models;

/// <summary>
/// 電視觀眾訂閱者
/// </summary>
public class TvAudienceObserver : BaseObserver
{
    /// <summary>
    /// 建構子
    /// </summary>
    public TvAudienceObserver()
    {
    }

    /// <summary>
    /// 收到通知
    /// </summary>
    /// <param name="message">訊息</param>
    public override void ReceiveNotify(string message)
    {
        Console.WriteLine($"TV觀眾收到通知:{message}");
    }
}