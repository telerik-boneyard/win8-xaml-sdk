using Nokia.Graphics.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Telerik.Windows.Controls;
using Nokia.InteropServices.WindowsRuntime;

namespace ImageEditorBlogPost
{
    public class CustomColorEffects : ColorEffectsTool
    {
        public List<IFilter> filters = new List<IFilter>();
        public GrayscaleFilter grayFilter = new GrayscaleFilter();
        public AutoLevelsFilter autoLevelsFilter = new AutoLevelsFilter();
        public NegativeFilter negativeFilter = new NegativeFilter();

        protected override async void OnIsColorInvertedChanged(bool newValue, bool oldValue)
        {
            if (newValue)
            {
                this.IsGreyscale = false;
                this.IsColorFixed = false;
                this.ResetWorkingBitmap();
                this.filters.Add(negativeFilter);
                this.ModifiedImage = await NokiaRenderer.Render(this.workingBitmap, filters);
            }
            else
            {
                this.ResetWorkingBitmap();
                this.filters.Clear();
                this.ModifiedImage = this.workingBitmap;
            }
        }

        protected override async void OnIsGreyscaleChanged(bool newValue, bool oldValue)
        {
            if (newValue)
            {
                this.IsColorInverted = false;
                this.IsColorFixed = false;
                this.ResetWorkingBitmap();
                this.filters.Add(grayFilter);
                this.ModifiedImage = await NokiaRenderer.Render(this.workingBitmap, filters);
            }
            else
            {
                this.ResetWorkingBitmap();
                this.filters.Clear();
                this.ModifiedImage = this.workingBitmap;
            }
        }

        protected override async void OnIsColorFixedChanged(bool newValue, bool oldValue)
        {
            if (newValue)
            {
                this.IsColorInverted = false;
                this.IsGreyscale = false;
                this.ResetWorkingBitmap();
                this.filters.Add(autoLevelsFilter);
                this.ModifiedImage = await NokiaRenderer.Render(this.workingBitmap, filters);

            }
            else
            {
                this.ResetWorkingBitmap();
                this.filters.Clear();
                this.ModifiedImage = this.workingBitmap;
            }
        }

        protected override async Task<WriteableBitmap> ApplyCore(WriteableBitmap actualImage)
        {
            return await NokiaRenderer.Render(actualImage, this.filters);
        }

    }
}
