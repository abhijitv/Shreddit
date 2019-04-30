using System;
using System.Collections.Generic;
using System.Text;
using SQLite;




namespace Shreddit.Interfaces
{
    public interface  ISQLite
    {

        SQLiteConnection GetConn();
      
    }
}
