using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Shreddit.Data;
using Xamarin.Forms;
using Shreddit.Commands;
using System.Diagnostics;


namespace Shreddit.ViewModels
{
   public  class MainVm
    {

        public  ICommand _saveFoodCommand{ get; private set; }
        public ShedItDBAccess _shedItDB  { get; private set; }
        public FoodConsumed _foodConsumed { get; private set; }
        public DateTime _dtConsumed { get; set; }

        public TimeSpan _tmConsumed { get; set; }
        public string  _foodItem { get; set; }

        public  MainVm()
        {
            _saveFoodCommand = new SaveFoodCommand(this );
            _dtConsumed = DateTime.Today;
            _tmConsumed = DateTime.Now.TimeOfDay; // to get the current time value 
         
            
        }

        public  void SaveFoodItem()
        {

            // create the new food item 
            _foodConsumed = new FoodConsumed();
            _foodConsumed.dtConsumed = _dtConsumed;
            _foodConsumed.FoodItem = _foodItem;

            // save the food item 
            Debug.WriteLine("hey this is command in use! ");
            _shedItDB = new ShedItDBAccess();
            
            _shedItDB.InsertData(_foodConsumed);


        }

    }
}
