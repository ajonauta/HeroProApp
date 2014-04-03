using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class GoPoleDataSource : IDataSource<HtmlSchema>
    {
        private IEnumerable<HtmlSchema> _data = new HtmlSchema[]
        {
            new HtmlSchema
            {
                Id = "{d926ddac-4eab-404e-90e4-b64121ba3776}",
                Content = "The GoPole allows you to capture yourself jumping that massive cliff or hitting t" +
    "he slopes<br><br><br><a href=\"http://gopole.com\" target=\"_blank\">GoPole.com</a>"
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
