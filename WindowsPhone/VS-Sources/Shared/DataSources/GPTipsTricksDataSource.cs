using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class GPTipsTricksDataSource : IDataSource<MenuSchema>
    {
        private readonly IEnumerable<MenuSchema> _data = new MenuSchema[]
		{
            new MenuSchema
            {
                Id = "{00000000-0000-0000-0000-000000000000}",
                Type = "Section",
                Title = "GoPro Tips",
                Icon = "/Assets/DataImages/gptips.png",
                Target = "GoProTipsView",
            },
            new MenuSchema
            {
                Id = "{00000000-0000-0000-0000-000000000000}",
                Type = "Section",
                Title = "GP Athlete Tips",
                Icon = "/Assets/DataImages/gpathlete.png",
                Target = "GPAthleteTipsView",
            },
            new MenuSchema
            {
                Id = "{00000000-0000-0000-0000-000000000000}",
                Type = "Section",
                Title = "GoPro DIY",
                Icon = "/Assets/DataImages/GPDIY.png",
                Target = "GoProDIYView",
            },
		};

        public async Task<IEnumerable<MenuSchema>> LoadData()
        {
            return await Task.Run(() =>
            {
                return _data;
            });
        }

        public async Task<IEnumerable<MenuSchema>> Refresh()
        {
            return await LoadData();
        }
    }
}
