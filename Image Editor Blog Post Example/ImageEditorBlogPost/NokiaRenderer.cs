using Nokia.Graphics.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Nokia.InteropServices.WindowsRuntime;

namespace ImageEditorBlogPost
{
    public static class NokiaRenderer
    {
        public async static Task<WriteableBitmap> Render(WriteableBitmap actualImage, List<IFilter> filters)
        {
            var bitmap = actualImage.AsBitmap();
            BitmapImageSource bitmapSource = new BitmapImageSource(bitmap);

            FilterEffect effects = new FilterEffect(bitmapSource);

            effects.Filters = filters;
            WriteableBitmapRenderer renderer = new WriteableBitmapRenderer(effects, actualImage);

            return await renderer.RenderAsync();

        }
    }
}
