using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class PolarProDataSource : IDataSource<HtmlSchema>
    {
        private IEnumerable<HtmlSchema> _data = new HtmlSchema[]
        {
            new HtmlSchema
            {
                Id = "{21ce59bb-3fc8-4c70-8e6f-5b9361486317}",
                Content = "PolarPro offers a variety of lenses for the GoPro camera, from magenta to ND. It " +
    "will apply a pro look to your footage.&nbsp;<br><br><a href=\"http://polarpro.com" +
    "\">PolarPro.com</a>"
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
