using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class GoProMountsDataSource : IDataSource<MenuSchema>
    {
        private readonly IEnumerable<MenuSchema> _data = new MenuSchema[]
		{
            new MenuSchema
            {
                Id = "{00000000-0000-0000-0000-000000000000}",
                Type = "Section",
                Title = "BRLS Mount",
                Icon = "/Assets/DataImages/brls.png",
                Target = "BRLSMountView",
            },
            new MenuSchema
            {
                Id = "{00000000-0000-0000-0000-000000000000}",
                Type = "Section",
                Title = "GoPole",
                Icon = "/Assets/DataImages/gopole.png",
                Target = "GoPoleView",
            },
            new MenuSchema
            {
                Id = "{00000000-0000-0000-0000-000000000000}",
                Type = "Section",
                Title = "RollPro 3 ",
                Icon = "/Assets/DataImages/rollpro.png",
                Target = "RollPro3View",
            },
            new MenuSchema
            {
                Id = "{00000000-0000-0000-0000-000000000000}",
                Type = "Section",
                Title = "GoFlex-Arm",
                Icon = "/Assets/DataImages/goflexarm.png",
                Target = "GoFlexArmView",
            },
            new MenuSchema
            {
                Id = "{00000000-0000-0000-0000-000000000000}",
                Type = "Section",
                Title = "PolarPro",
                Icon = "/Assets/DataImages/polarpro.png",
                Target = "PolarProView",
            },
            new MenuSchema
            {
                Id = "{00000000-0000-0000-0000-000000000000}",
                Type = "Section",
                Title = "Original Handle",
                Icon = "/Assets/DataImages/originalhandle.png",
                Target = "OriginalHandleView",
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
