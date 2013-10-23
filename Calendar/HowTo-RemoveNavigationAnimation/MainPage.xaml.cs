using Telerik.UI.Xaml.Controls.Input.Calendar;
using Telerik.UI.Xaml.Controls.Input.Calendar.Commands;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace HowTo_RemoveNavigationAnimation
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }

    public class CustomMoveToUpperViewCommand : CalendarCommand
    {
        public CustomMoveToUpperViewCommand()
        {
            this.Id = CommandId.MoveToUpperView;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            (parameter as CalendarViewChangeContext).AnimationStoryboard = null;
            this.Owner.CommandService.ExecuteDefaultCommand(CommandId.MoveToUpperView, parameter);
        }
    }
}