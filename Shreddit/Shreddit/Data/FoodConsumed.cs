using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
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

    public class GroupedFoodConsumed : ObservableCollection<FoodConsumed>
    {
        public string  Heading { get; set; }
    }

    public class DateConsumed
    {
        public DateTime dtConsumed { get; set; }
    }
}
