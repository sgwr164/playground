using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    public class IncrementAgeCommand : ICommand
    {
        private Person vm;

        public IncrementAgeCommand(Person viewmodel)
        {
            vm = viewmodel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return (vm.Age < 17);
        }

        public void Execute(object parameter)
        {
            vm.Age++;
            CanExecuteChanged(parameter, null);
        }
    }
}
