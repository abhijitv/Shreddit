using System;
using System.Collections.Generic;
using System.Text;

using SQLite;
using System.ComponentModel;

namespace Shreddit.Data
{
    [Table("FoodConsumed")]
    public class FoodConsumed
    {


        [PrimaryKey, AutoIncrement]
        public int GUID { get; set; }
        public DateTime dtConsumed { get; set; }
        public string FoodItem { get; set; }
        public DateTime TimeConsumed { get; set; }
    }
}
