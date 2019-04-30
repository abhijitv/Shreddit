using System;
using System.Collections.Generic;
using System.Text;
using Shreddit.Data;
using System.Collections;


namespace Shreddit.ViewModels
{
    class MyDietHistoryVM
    {
        //Class having data structure 
        public List<FoodConsumed> MyDietHistory { get; set; }
        //class for data access 
        public ShedItDBAccess DBAccess { get; set; }
        public MyDietHistoryVM()
        {

            GetDietHistory();

        }

        void GetDietHistory()
        {

            DBAccess = new ShedItDBAccess();
            MyDietHistory = DBAccess.GetDietHistory();

        }

    }
}
