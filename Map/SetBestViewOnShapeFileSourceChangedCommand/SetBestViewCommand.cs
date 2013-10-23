using Telerik.UI.Xaml.Controls.Map;

namespace SetBestViewOnShapeFileSourceChangedCommand
{
    public class SetBestViewCommand : MapCommand
    {
        public SetBestViewCommand()
        {
            this.Id = CommandId.ShapeLayerSourceChanged;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            base.Execute(parameter);
            var shapeLayer = parameter as MapShapeLayer;
            this.Owner.SetView(shapeLayer.Bounds);
            this.Owner.CommandService.ExecuteDefaultCommand(CommandId.ShapeLayerSourceChanged, parameter);
        }
    }
}