using Telerik.Core;

namespace SetBestViewOnShapeFileSourceChangedCommand
{
    public class ViewModel : ViewModelBase
    {
        private string sourceUriString;
        private string dataSourceUriString;

        public ViewModel()
        {
            this.ChangeSourceCommand = new ChangeSourceCommand(this);
            this.DataSourceUriString = "ms-appx:///Data/africa.dbf";
            this.SourceUriString = "ms-appx:///Data/africa.shp";
        }

        public ChangeSourceCommand ChangeSourceCommand { get; set; }

        public string SourceUriString
        {
            get
            {
                return this.sourceUriString;
            }
            set
            {
                if (this.sourceUriString != value)
                {
                    this.sourceUriString = value;
                    OnPropertyChanged();
                }
            }
        }

        public string DataSourceUriString
        {
            get
            {
                return this.dataSourceUriString;
            }
            set
            {
                if (this.dataSourceUriString != value)
                {
                    this.dataSourceUriString = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}