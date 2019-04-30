using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Shreddit.ViewModels;

namespace Shreddit.Commands
{
  public   class SaveFoodCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private MainVm _mainVM;
        public bool CanExecute(object parameter)
        {
            return true;
            //throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {

            _mainVM.SaveFoodItem();
            //throw new NotImplementedException();
        }
        public SaveFoodCommand(MainVm mainVM )
        {
            _mainVM = mainVM;
        }
    }
}
