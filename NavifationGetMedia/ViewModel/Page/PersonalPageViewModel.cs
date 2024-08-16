using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using NavifationGetMedia.Model;

namespace NavifationGetMedia.ViewModel.Page
{
    public class PersonalPageViewModel : ObservableObject
    {
        public ObservableCollection<PersonalModel> PersonalModel
        {
            get => GetOrCreate<ObservableCollection<PersonalModel>>();
            set => SetAndNotify(value);
        }

        public PersonalPageViewModel(ObservableCollection<PersonalModel> personalModels)
        {
            PersonalModel = personalModels;
            var s = new PersonalModel();
            s.Departament = "aaaaaa";

            for (int i = 0; i < 100; i++)
            {
                PersonalModel.Add(s);
            }
        }
    }
}
