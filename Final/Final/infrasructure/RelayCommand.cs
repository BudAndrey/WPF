using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Final.infrasructure
{
    class RelayCommand:ICommand
    {
        private readonly Action<object> action;
        private readonly Predicate<object> predicate;
        public RelayCommand(Action<object> a, Predicate<object> b = null)
        {
            action = a;
            predicate = b;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove 
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return predicate == null ? true : predicate(parameter);
        }

        public void Execute(object parameter)
        {
            action(parameter);
        }
    }
}
