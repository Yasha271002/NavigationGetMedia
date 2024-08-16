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

        public bool SelectPageButton
        {
            get => GetOrCreate<bool>();
            set => SetAndNotify(value);
        }

        public bool IsKeyboardVisible
        {
            get => GetOrCreate<bool>();
            set => SetAndNotify(value);
        }

        public MainWindowViewModel()
        {
            MapModel = new MapModel();
            PersonalModels = new ObservableCollection<PersonalModel>();
            SelectPageButton = true;
            GetAllPersonalInfo();
        }

        public ICommand ShowKeyBoardCommand => GetOrCreate(new RelayCommand(f =>
        {
            IsKeyboardVisible = true;
        }));
        
        public ICommand HideKeyBoardCommand => GetOrCreate(new RelayCommand(f =>
        {
            IsKeyboardVisible = false;
        }));

        public ICommand SwitchPageCommand => GetOrCreate(new RelayCommand(f =>
        {
            if (f == PersonalModels)
            {
                CommonCommands.NavigateCommand.Execute(PersonalModels);
                SelectPageButton = false;
            }
            else
            {
                CommonCommands.NavigateCommand.Execute(MapModel);
                SelectPageButton = true;
            }
        }));

        private void GetAllPersonalInfo()
        {
            //Из Json всё забираем. По крайней мере я надеюсь на json
        }
    }
}
