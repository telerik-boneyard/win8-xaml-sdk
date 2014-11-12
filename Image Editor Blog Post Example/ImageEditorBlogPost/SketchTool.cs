using Nokia.Graphics.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls;
using Nokia.InteropServices.WindowsRuntime;

namespace ImageEditorBlogPost
{
    public class SketchTool : ImageEditorTool
    {
        public List<IFilter> filters = new List<IFilter>();
        public SketchFilter sketchFilter = new SketchFilter();

        public SketchTool()
        {
            filters.Add(sketchFilter);
        }

        public override string Name
        {
            get { return "Sketch Tool"; }
        }

        public override string Icon
        {
            get { return @"/ImageEditorBlogPost;Component/Assets/sketch-light.png";}
        }

        private bool isGrayChecked;
        public bool IsGrayChecked
        {
            get
            {
                return this.isGrayChecked;
            }

            set
            {

                if (this.isGrayChecked == value)
                {
                    return;
                }

                this.isGrayChecked = value;

                if (value)
                {
                    this.OnSketchModeChanged(SketchMode.Gray);
                }

                
                this.OnPropertyChanged("IsGrayChecked");
            }
        }

        private bool isColorChecked;
        public bool IsColorChecked
        {
            get
            {
                return this.isColorChecked;
            }

            set
            {
                if (this.isColorChecked == value)
                {
                    return;
                }

                this.isColorChecked = value;


                if (value)
                {
                    this.OnSketchModeChanged(SketchMode.Color);
                }

                this.OnPropertyChanged("IsColorChecked");
            }
        }  

        protected override async Task<System.Windows.Media.Imaging.WriteableBitmap> ApplyCore(System.Windows.Media.Imaging.WriteableBitmap actualImage)
        {
           actualImage = await NokiaRenderer.Render(actualImage, filters);

            return actualImage;  
        }

        protected async void OnSketchModeChanged(SketchMode mode)
        {
                this.sketchFilter.SketchMode = mode;
                this.ResetWorkingBitmap();
                this.workingBitmap = await NokiaRenderer.Render(this.workingBitmap, filters);
                this.ModifiedImage = this.workingBitmap;
        }


    }

}
