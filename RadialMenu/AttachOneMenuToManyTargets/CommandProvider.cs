using System;
using System.Windows.Input;
using Telerik.UI.Xaml.Controls.Primitives.Menu;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace AttachOneMenuToManyTargets
{
    public class CommandProvider
    {
        public CommandProvider()
        {
            this.SetBackgroundCommand = new SetBackgroundCommand();
            this.SetForegroundCommand = new SetForegroundCommand();
            this.SetBorderColorCommand = new SetBorderColorCommand();
        }

        public ICommand SetBackgroundCommand { get; set; }

        public ICommand SetForegroundCommand { get; set; }

        public ICommand SetBorderColorCommand { get; set; }
    }

    public class SetBorderColorCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event System.EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            var context = parameter as RadialMenuItemContext;
            var border = context.TargetElement as Border;

            var color = context.MenuItem.ContentSectorBackground;
            if (color == null)
            {
                color = new SolidColorBrush(Colors.LightGray);
            }

            border.BorderBrush = color;
        }
    }

    public class SetForegroundCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event System.EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            var context = parameter as RadialMenuItemContext;
            var border = context.TargetElement as Border;
            var textBlock = border.Child as TextBlock;

            var color = context.MenuItem.ContentSectorBackground;
            if (color == null)
            {
                color = new SolidColorBrush(Colors.Black);
            }

            textBlock.Foreground = color;
        }
    }

    public class SetBackgroundCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event System.EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            var context = parameter as RadialMenuItemContext;
            var border = context.TargetElement as Border;

            var color = context.MenuItem.ContentSectorBackground;
            if (color == null)
            {
                color = new SolidColorBrush(Colors.White);
            }

            border.Background = color;
        }
    }
}