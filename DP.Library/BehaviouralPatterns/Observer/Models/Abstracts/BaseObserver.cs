namespace DP.Library.BehaviouralPatterns.Observer.Models.Abstracts;

/// <summary>
/// 訂閱者 基底
/// </summary>
public abstract class BaseObserver
{
    /// <summary>
    /// 收到通知
    /// </summary>
    /// <param name="message">訊息</param>
    public abstract void ReceiveNotify(string message);
}
