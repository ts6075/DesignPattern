using DP.Library.BehaviouralPatterns.Observer.Models;

namespace DP.Library.BehaviouralPatterns.Observer.Services;

/// <summary>
/// 觀察者模式
/// </summary>
public class Observer
{
    /// <summary>
    /// 主程式
    /// </summary>
    public void Main()
    {
        // 建立主題
        NewsSubject newsSubject = new();

        // 加入訂閱者
        newsSubject.Add(new AppAudienceObserver());
        newsSubject.Add(new TvAudienceObserver());

        // 發送訊息
        newsSubject.Notify("測試訊息");
    }
}