using DP.Library.BehaviouralPatterns.Observer.Models.Abstracts;

namespace DP.Library.BehaviouralPatterns.Observer.Models;

/// <summary>
/// App觀眾訂閱者
/// </summary>
public class AppAudienceObserver : BaseObserver
{
    /// <summary>
    /// 建構子
    /// </summary>
    public AppAudienceObserver()
    {
    }

    /// <summary>
    /// 收到通知
    /// </summary>
    /// <param name="message">訊息</param>
    public override void ReceiveNotify(string message)
    {
        Console.WriteLine($"App觀眾收到通知:{message}");
    }
}