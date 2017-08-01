using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ScheduleVis
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            outputText = "Ready to Parse files";
        }

        public void AddMessage(string msg)
        {
            outputText += msg + Environment.NewLine;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OutputText"));
        }

        private string outputText;
        public string OutputText
        {
            get
            {
                return outputText;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
