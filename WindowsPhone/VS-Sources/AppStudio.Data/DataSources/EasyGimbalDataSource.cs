using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class EasyGimbalDataSource : IDataSource<HtmlSchema>
    {
        private IEnumerable<HtmlSchema> _data = new HtmlSchema[]
        {
            new HtmlSchema
            {
                Id = "{c09df44b-23a3-4162-8774-0254bd92bb97}",
                Content = "The Easy Gimbal allows you to get those smooth shots you\'ve dreaming!<br><br><br>" +
    "<a href=\"http://easygimbal.com\">Go to EasyGimbal.com</a>"
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
