using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Dostoevsci.Core
{
    class Class1 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name)); 
        }
    }
}
