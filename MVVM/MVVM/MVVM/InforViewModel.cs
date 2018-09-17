using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MVVM
{
    class InforViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private InforData _model = new InforData();

        public InforViewModel()
        {
            this.GanderList = new List<GenderViewModel>()
            {
                new GenderViewModel(){ Gander=Gender.Boy,DisplayName="男"},
                new GenderViewModel(){ Gander=Gender.Girl,DisplayName="女"}
            };

        }


        public string Name
        {
            get
            {
                return _model.Name;
            }
            set
            {
                this._model.Name = value;
                this.PropertyChanged?.DynamicInvoke(this, new PropertyChangedEventArgs(nameof(this.Name)));
            }
        }

        public string Email
        {
            get
            {
                return this._model.Email;
            }
            set
            {
                this.Email = value;
                this.PropertyChanged?.DynamicInvoke(this, new PropertyChangedEventArgs(nameof(this.Email)));
            }
        }

        public DateTime Birthday
        {
            get
            {
                return this._model.Birthday;
            }
            set
            {
                this.Birthday = value;
                this.PropertyChanged?.DynamicInvoke(this, new PropertyChangedEventArgs(nameof(this.Birthday)));
            }
        }

        public string ImagePath
        {
            get
            {
                return this._model.ImagePath;
            }
        }

        public IEnumerable<GenderViewModel> GanderList
        {
            get;
        }

        


    }
}
