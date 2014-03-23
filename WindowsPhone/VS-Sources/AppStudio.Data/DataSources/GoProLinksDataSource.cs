using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class GoProLinksDataSource : IDataSource<HtmlSchema>
    {
        private IEnumerable<HtmlSchema> _data = new HtmlSchema[]
        {
            new HtmlSchema
            {
                Id = "{854f327a-4a9d-4fde-8e4a-96cb9758a283}",
                Content = @"<p><a rel=""nofollow"" target=""_blank"" href=""http://gopro.com"">The official GoPro Website</a>
</p><p><a rel=""nofollow"" target=""_blank"" href=""http://cam-do.com"">Unofficial GoPro Accesories</a>
</p><p><a rel=""nofollow"" target=""_blank"" href=""http://gopole.com"">GoPro Poles, Handles and more.</a>
</p><p><a rel=""nofollow"" target=""_blank"" href=""http://riseful.com/products/rollproiii"">A amazing bag for GoPros</a>
</p><p><a rel=""nofollow"" target=""_blank"" href=""http://go-mount.com"">A GoPro versatile Clamp and a useful GoPro Arm extension</a>
</p><p><a rel=""nofollow"" target=""_blank"" href=""http://brlshawaii.com"">A extreme handy GoPro Suction cup for Snow/surf/WHATEVER!</a></p>"
            }
        };

        public async Task<IEnumerable<HtmlSchema>> LoadData()
        {
            return await Task.Run(() =>
            {
                return _data;
            });
        }

        public async Task<IEnumerable<HtmlSchema>> Refresh()
        {
            return await LoadData();
        }
    }
}
