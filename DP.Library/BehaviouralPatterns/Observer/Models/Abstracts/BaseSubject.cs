namespace DP.Library.BehaviouralPatterns.Observer.Models.Abstracts;

/// <summary>
/// 訂閱主題 基底
/// </summary>
public abstract class BaseSubject
{
    /// <summary>
    /// 訂閱者清單
    /// </summary>
    private readonly IList<BaseObserver> _observers;

    /// <summary>
    /// 建構子
    /// </summary>
    public BaseSubject()
    {
        _observers = new List<BaseObserver>();
    }

    /// <summary>
    /// 加入訂閱者
    /// </summary>
    /// <param name="observer">訂閱者</param>
    public void Add(BaseObserver observer)
    {
        _observers.Add(observer);
    }

    /// <summary>
    /// 移除訂閱者
    /// </summary>
    /// <param name="observer">訂閱者</param>
    public void Remove(BaseObserver observer)
    {
        _observers.Remove(observer);
    }

    /// <summary>
    /// 通知訂閱者
    /// </summary>
    /// <param name="message">訊息</param>
    public void Notify(string message)
    {
        foreach (BaseObserver observer in _observers)
        {
            observer.ReceiveNotify(message);
        }
    }
}
