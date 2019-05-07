using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Windows.Input;
using SQLite;

using Shreddit.Interfaces;
using System.ComponentModel;


namespace Shreddit.Data
{
    public class ShedItDBAccess
    {

        private SQLiteConnection conn;


        public ShedItDBAccess()
        {

            // get a connection from the DB 
            conn = DependencyService.Get<ISQLite>().GetConn();
            //create the table 
            conn.CreateTable<FoodConsumed>();
        }

        public void InsertData(FoodConsumed fdConsumed)
        {

            conn.Insert(fdConsumed);
        }

        public List<FoodConsumed> GetDietHistory()
        {
            return conn.Query<FoodConsumed>("select * from [FoodConsumed]");

        }

       public List<DateConsumed> GetUniqueDates()
        {

            return conn.Query<DateConsumed>("select distinct (dtConsumed)  from  [FoodConsumed]");
        }

    }
}
