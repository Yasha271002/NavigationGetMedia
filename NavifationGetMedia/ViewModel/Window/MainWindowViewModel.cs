using System.Collections.ObjectModel;
using System.Windows.Input;
using Core;
using NavifationGetMedia.Helpers;
using NavifationGetMedia.Model;

namespace NavifationGetMedia.ViewModel.Window
{
    public class MainWindowViewModel : ObservableObject
    {
        public ObservableCollection<PersonalModel> PersonalModels
        {
            get => GetOrCreate<ObservableCollection<PersonalModel>>();
            set => SetAndNotify(value);
        }

        public MapModel MapModel
        {
            get => GetOrCreate<MapModel>();
            set => SetAndNotify(value);
        }

        public MainWindowViewModel()
        {
            PersonalModels = new ObservableCollection<PersonalModel>();
            GetAllPersonalInfo();
        }

        public ICommand SwitchPageCommand => GetOrCreate(new RelayCommand(f =>
        {
            if (f == PersonalModels)
            {
                CommonCommands.NavigateCommand.Execute(PersonalModels);
            }
            else
            {
                CommonCommands.NavigateCommand.Execute(MapModel);
            }
        }));

        private void GetAllPersonalInfo()
        {
            //Из Json всё забираем. По крайней мере я надеюсь на json
        }
    }
}
