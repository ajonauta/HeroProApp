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
                Id = "{37e9920b-641c-4ea6-ae22-fbad7243eaf5}",
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
