using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForDG
{
   public class User : INotifyPropertyChanged
    {
        private string name;

        public string Name {

            get => name;
            
            set
            {
                if(name != value)
                {
                    name = value;
                    NotifyPropertyChanged(nameof(Name));
                }
            }
        
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
