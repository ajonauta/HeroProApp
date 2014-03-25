using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class SandmarcTripodMountDataSource : IDataSource<HtmlSchema>
    {
        private IEnumerable<HtmlSchema> _data = new HtmlSchema[]
        {
            new HtmlSchema
            {
                Id = "{5a4d55fa-e927-4694-ab82-a5bcfc24a040}",
                Content = "The Sandmarc Tripod Mount allows you to mount your gopro on a tripod with style.<" +
    "br><br><br><a href=\"http://sandmarc.com/products/sandmarc-aluminum-tripod-mount\"" +
    ">Go to Sandmarc Tripod Mount page.</a>"
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
