using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Android.App;
using Android.Content;

using Android.Runtime;
using Android.Views;
using Shreddit.Droid;
using Xamarin.Forms;
using Shreddit.Interfaces;
using SQLite;

[assembly: Dependency(typeof(SQlite_Android))]
namespace Shreddit.Droid
{
    
    public class SQlite_Android: ISQLite
    {
        public SQLiteConnection GetConn()
        {
            var DBname = "ShedItDb.db3";

            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), DBname);
            return new SQLite.SQLiteConnection(path);

        }

        
    }
}