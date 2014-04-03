using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class DJIPhantomDataSource : IDataSource<HtmlSchema>
    {
        private IEnumerable<HtmlSchema> _data = new HtmlSchema[]
        {
            new HtmlSchema
            {
                Id = "{36dfebc8-0c90-4579-a57d-66070b7e0f80}",
                Content = "The DJI Phantom is a quadcopter that can carry a GoPro camera and a gimbal, the p" +
    "hantom is great for aerial shots and it is widely used in TV.<br><br><br><a href" +
    "=\"http://dji.com\">Go to DJI.com</a>"
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
