using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HealthClub.Droid;
using HealthClub.Model;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteAndroid))]
namespace HealthClub.Droid
{
    public class SQLiteAndroid : SQLiteInterface
    {
        SQLiteConnection con;
        public SQLiteConnection GetConnectionForDatabase()
        {
            var dbName = "HealthClubDB.db3";
            var dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(dbPath, dbName);
            con = new SQLiteConnection(path);
            con.CreateTable<Customer>();
            return con;
        }
    }
}