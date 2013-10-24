using System.Windows.Input;
using Telerik.Core;

namespace AttachOneMenuToManyTargets
{
    public class ViewModel : ViewModelBase
    {
        public MenuItem Foreground { get; set; }
    }
  
    public class MenuItem
    {
        public string Header { get; set; }

        public ICommand Command { get; set; }
    }
}