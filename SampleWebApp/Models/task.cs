using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp.Models
{
    public class Task
    {

    /// <summary>
    /// タスクのID
    /// </summary>
    public int TaskID { get; set; }

    /// <summary>
    /// タスクのタイトル
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// ユーザID
    /// </summary>
    public User UserInfo { get; set; }

    /// <summary>
    /// stateのID
    /// </summary>
    public State StateInfo { get; set; }

    /// <summary>
    /// ImportanceのID
    /// </summary>
    public Importance ImportanceInfo{ get; set; }

    /// <summary>
    /// 説明内容
    /// </summary>
    public String Explain { get; set; }

    /// <summary>
    /// 期日
    /// </summary>
    public DateTime Datetime { get; set; } 
    }
}