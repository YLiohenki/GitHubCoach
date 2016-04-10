using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidGitHubCoach.Model
{
    public interface IRepository
    {
        T FetchData<T>(string key);

        bool StoreData<T>(string key, T data);
    }
}