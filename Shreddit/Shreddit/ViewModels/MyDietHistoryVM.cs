using System;
using System.Collections.Generic;
using System.Text;
using Shreddit.Data;
using System.Collections;
using System.Collections.ObjectModel;


namespace Shreddit.ViewModels
{
    class MyDietHistoryVM
    {
        //Class having data structure 
        public List<FoodConsumed> myDietHistory { get; set; }
        public ObservableCollection<GroupedFoodConsumed> groupedDietHistory { get; set; }
        //class for data access 
        private ShedItDBAccess DBAccess { get; set; }

        public List<DateConsumed> GroupHeadings { get; set; }


        public MyDietHistoryVM()
        {

            // create the DB 
            DBAccess = new ShedItDBAccess();

            // get the raw data from DB 
            GetDietHistory();

            //create the grouped list by date 

            FindUniqueDates();

            GetGroupedDietHistory();
        }

        void GetDietHistory()
        {

            myDietHistory = DBAccess.GetDietHistory();

        }

        void GetGroupedDietHistory()
        {

            groupedDietHistory = new ObservableCollection<GroupedFoodConsumed>();
            foreach  ( DateConsumed  dc in GroupHeadings)
            {

                GroupedFoodConsumed gfc = new GroupedFoodConsumed() { Heading =  dc.dtConsumed.ToString("MMMM") + ' ' + dc.dtConsumed.Day.ToString() + ' ' +  dc.dtConsumed.Year.ToString() };
                groupedDietHistory.Add(gfc);

                foreach(FoodConsumed fc in myDietHistory)
                {

                    if (fc.dtConsumed == dc.dtConsumed)
                    gfc.Add(fc);
                }


            }
           
        }

        void FindUniqueDates()
        {

            GroupHeadings = DBAccess.GetUniqueDates();

        }

    }
}
