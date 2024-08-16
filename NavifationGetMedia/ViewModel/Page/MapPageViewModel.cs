using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using NavifationGetMedia.Model;

namespace NavifationGetMedia.ViewModel.Page
{
    public class MapPageViewModel : ObservableObject
    {
        public MapModel MapModel
        {
            get => GetOrCreate<MapModel>();
            set => SetAndNotify(value);
        }

        public MapPageViewModel(MapModel mapModel)
        {
            MapModel = mapModel;
        }
    }
}
