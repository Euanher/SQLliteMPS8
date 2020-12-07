using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Clothes
{
    public class MainVeiwModel : INotifyPropertyChanged
    {
        private string Name = string.Empty;
        private string name;

        public string GetName()
        {
            return Name;
        }

        public void SetName(string value)
        {
            if (GetName() == value)
                return;

            name = value;
            string v = GetName();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(v)));
            OnPropertyChanged(nameof(DisplayName));
        }

        private void OnPropertyChanged(string v)
        {
            throw new NotImplementedException();
        }

        public string DisplayName => $"Name Entered: {GetName()}";

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
