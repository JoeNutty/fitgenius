using System.IO;
using SQLite;
using Xamarin.Forms;
using FitGenius.Droid;
using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Environment = System.Environment;

[assembly: Dependency(typeof(SQLiteDb))]

namespace FitGenius.Droid
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var path = Path.Combine(documentsPath, "FitGenius.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}
