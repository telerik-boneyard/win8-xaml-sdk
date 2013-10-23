using System;
using System.Windows.Input;

namespace SetBestViewOnShapeFileSourceChangedCommand
{
    public class ChangeSourceCommand : ICommand
    {
        public ViewModel Parent { get; private set; }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            var filename = parameter as string;
            if (!string.IsNullOrEmpty(filename))
            {
                this.Parent.DataSourceUriString = "ms-appx:///Data/" + filename + ".dbf";
                this.Parent.SourceUriString = "ms-appx:///Data/" + filename + ".shp";
            }
        }

        public ChangeSourceCommand(ViewModel parent)
        {
            this.Parent = parent;
        }
    }
}