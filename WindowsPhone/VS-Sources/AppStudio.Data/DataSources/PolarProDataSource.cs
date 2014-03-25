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
                Id = "{c4b691ac-55e8-4545-8d15-9c9aab5fa0a4}",
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
